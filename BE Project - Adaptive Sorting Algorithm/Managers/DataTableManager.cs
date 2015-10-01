using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.VectorMachines;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Filters;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;
using Accord.Statistics.Models.Regression.Linear;

namespace BE_Project___Adaptive_Sorting_Algorithm.Managers
{
    class DataTableManager
    {
        // Original Data table
        public DataTable Table { get; }
        // Symbol table generated from Data table
        public DataTable Symbols { get; set; }

        // Codified Input[] vector
        public double[][] Inputs { get; set; }
        // Codified Output vector
        public int[] Outputs { get; set; }

        // Input Symbol Counts
        private int[] SymbolCounts;
        // Output Class Counts
        private int ClassCount;

        // ML Algorithms and consequent learning classes
        private DecisionTree tree;
        private C45Learning c45;

        private MulticlassSupportVectorMachine mcsvm;
        private MulticlassSupportVectorLearning mcsvmLearning;

        private NaiveBayes nb;

        private MultipleLinearRegression linearRegression;

        // Inputs formatted to int[][]
        private int[][] IntInputs;
        private double[] DoubleOutputs;

        private double rA, rB, rC;

        // Labels for the DataTable
        private string[] inputColumns =
        {
            "Array Size", "Runs", /*"Array Type",*/ "Insertion Sort (\u03BCs)", "Shell Sort (\u03BCs)",
            "Heap Sort (\u03BCs)", "Merge Sort (\u03BCs)", "Quick Sort (\u03BCs)", "Parallel Merge Sort (\u03BCs)"
        };
        private string outputColumn = "Selected Sorting Algorithm";

        private Codification codebook;

        public DataTableManager()
        {
            Table = new DataTable("Sorting Table");
            foreach (string t in inputColumns)
                Table.Columns.Add(t);
            Table.Columns.Add(outputColumn);
        }

        // Add each result one by one
        public void AddResult(JsonManager.Result r)
        {
            object[] sr =
            {
                r.arraySize + "", r.runs + "", /*r.arraytype,*/  r.insertionSortExecutionTime + "",
                r.shellSortExecutionTime + "", r.heapSortExecutionTime + "", r.mergeSortExecutionTime + "",
                r.quickSortExecutionTime + "", r.parallelMergeSortExecutionTime + "", r.bestClass
            };
            Table.Rows.Add(sr);
        }

        // Load the Data Table with all of the JSONManager data
        public void LoadAllResults()
        {
            string line;
            string filename;
            string[][] arrays = { JsonManager.array100, JsonManager.array1000, JsonManager.array10000, JsonManager.array100000, JsonManager.array1000000 };
            JsonManager.Result result;

            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    filename = arrays[i][j];

                    foreach (string json in JsonManager.GetNextResult(filename))
                    {
                        result = JsonManager.ParseResult(json);
                        AddResult(result);
                    }
                }
            }
        }

        public void SortTable(bool sort)
        {
            if (sort)
            {
                Table.DefaultView.Sort = "Array Size ASC, Runs ASC";
            }
            else
            {
                Table.DefaultView.Sort = "Array Size ASC";
            }
        }

        // Convert Data Table of strings into double[] inputs and int output
        // Constructs the Symbol table
        public void Codify()
        {
            string[] cols = {"Array Size", "Runs", "Selected Sorting Algorithm"};
            string[] cols_ip = {"Array Size", "Runs"};
            string cols_op = "Selected Sorting Algorithm";

            codebook = new Codification(Table, cols);
            Symbols = codebook.Apply(Table);
            Inputs = Symbols.ToArray(cols_ip);
            Outputs = Symbols.ToArray<int>(cols_op);

            IntInputs = Symbols.ToArray<int>(cols_ip);
            DoubleOutputs = Symbols.ToArray<double>(cols_op);

            SymbolCounts = new int[2] { codebook["Array Size"].Symbols, codebook["Runs"].Symbols };
            ClassCount = codebook["Selected Sorting Algorithm"].Symbols;

            // Declares the Sorting methods needed : All except HeapSort
            var x = codebook["Selected Sorting Algorithm"].Mapping;
            foreach(var val in x.Keys) 
                Console.WriteLine(val + "");
        }

        // Loads up the Decision Tree
        public void CreateDecisionTree()
        {
            string[] cols = { "Array Size", "Runs" };
            var attributes = DecisionVariable.FromCodebook(codebook, cols);
            tree = new DecisionTree(attributes, ClassCount);
        }

        // Returns Error as a percentage. Best is 0.0, Worst is 1.0
        public double TreeLearn()
        {
            c45 = new C45Learning(tree);
            return c45.Run(Inputs, Outputs);
        }

        // Actual Selection using Decision Tree
        public string GetBestAlgorithmForInputTree(string[] input, bool returnNonTranslatedInt)
        {
            try
            {
                double[] codes = { codebook.Translate("Array Size", input[0]), codebook.Translate("Runs", input[1]) };
                int result = tree.Compute(codes);
                string bestAlgorithm;
                if (returnNonTranslatedInt)
                {
                    bestAlgorithm = result + "";
                }
                else
                {
                    bestAlgorithm = codebook.Translate("Selected Sorting Algorithm", result);
                }

                return bestAlgorithm;
            }
            catch (Exception ex)
            {
                return "Could not match inputs";
            }
        }

        public string GetBestAlgorithmForNaiveBayes(string[] input, bool returnNonTranslatedInt)
        {
            try
            {
                int[] codes = { codebook.Translate("Array Size", input[0]), codebook.Translate("Runs", input[1]) };
                int result = nb.Compute(codes);
                string bestAlgorithm;
                if (returnNonTranslatedInt)
                {
                    bestAlgorithm = result + "";
                }
                else
                {
                    bestAlgorithm = codebook.Translate("Selected Sorting Algorithm", result);
                }

                return bestAlgorithm;
            }
            catch (Exception ex)
            {
                return "Could not match inputs";
            }
        }

        // Loads the Multi Class SVM and its Kernel Function (Linear)
        public void CreateMCSVM()
        {
            string[] cols = { "Array Size", "Runs" };
            IKernel kernel = new Linear();
            mcsvm = new MulticlassSupportVectorMachine(inputs: 2, kernel: kernel, classes: ClassCount);
        }

        // Creates the Learning function for MC-SVM : SequentialMinimalOptimization with a hardline Complexity of 0.1
        public double MCSVMLearn()
        {
            mcsvmLearning = new MulticlassSupportVectorLearning(mcsvm, Inputs, Outputs);
            mcsvmLearning.Algorithm = (machine, inputs, outputs, class1, class2) => new LinearDualCoordinateDescent(machine, inputs, outputs)
            {
                Complexity = 0.007
            };

            return mcsvmLearning.Run();
        }

        // Actual Selection using MultiClass-SupportVectorMachine
        public string GetBestAlgorithmForInputMCSVM(string[] input, bool returnNonTranslatedInt)
        {
            try
            {
                double[] codes = { codebook.Translate("Array Size", input[0]), codebook.Translate("Runs", input[1]) };
                int result = mcsvm.Compute(codes);
                string bestAlgorithm;
                if (returnNonTranslatedInt)
                {
                    bestAlgorithm = result + "";
                }
                else
                {
                    bestAlgorithm = codebook.Translate("Selected Sorting Algorithm", result);
                }

                return bestAlgorithm;
            }
            catch (Exception ex)
            {
                return "Could not match inputs";
            }
        }
        
        // Creates Naive Bayes Machine
        public void CreateNaiveBayes()
        {
            string[] cols = { "Array Size", "Runs" };
            nb = new NaiveBayes(ClassCount, SymbolCounts);
        }

        // Utilizes Naive Bayes inbuilt Estimation for Learning
        public double LearnNaiveBayes()
        {
            return nb.Estimate(IntInputs, Outputs);
        }

        // Actual Selection using MultiClassSupportVectorMachine
        public string GetBestAlgorithmForInputNaiveBayes(string[] input, bool returnNonTranslatedInt)
        {
            try
            {
                int[] codes = { codebook.Translate("Array Size", input[0]), codebook.Translate("Runs", input[1]) };
                int result = nb.Compute(codes);
                string bestAlgorithm;
                if (returnNonTranslatedInt)
                {
                    bestAlgorithm = result + "";
                }
                else
                {
                    bestAlgorithm = codebook.Translate("Selected Sorting Algorithm", result);
                }
                return bestAlgorithm;
            }
            catch (Exception ex)
            {
                return "Could not match inputs";
            }
        }

        public void CreateLinearRegression()
        {
            linearRegression = new MultipleLinearRegression(2, true);
        }

        public double LearnLinearRegression()
        {
            double error = linearRegression.Regress(Inputs, DoubleOutputs);
            rA = linearRegression.Coefficients[0];
            rB = linearRegression.Coefficients[1];
            rC = linearRegression.Coefficients[2];
            Console.WriteLine("Regression values : {0}, {1}, {2}", rA, rB, rC);
            return error;
        }

        // Actual Selection using MultiClassSupportVectorMachine
        public string GetBestAlgorithmForLinearRegression(string[] input, bool returnNonTranslatedInt)
        {
            try
            {
                double[] codes = { codebook.Translate("Array Size", input[0]), codebook.Translate("Runs", input[1]) };
                double result = rA*codes[0] + rB*codes[1] + rC;

                string bestAlgorithm;
                if (returnNonTranslatedInt)
                {
                    bestAlgorithm = (int) Math.Round(result) + "";
                }
                else
                {
                    bestAlgorithm = codebook.Translate("Selected Sorting Algorithm", (int) Math.Round(result));
                    if (bestAlgorithm == null)
                    {
                        Console.WriteLine("Null at Result = {0}", Math.Round(result));
                        bestAlgorithm = "Null";
                    }
                }

                return bestAlgorithm;
            }
            catch (Exception ex)
            {
                return "Could not match inputs";
            }
        }

        // Stores the generated DecisionTree into a .dll file so we can decompile
        // the class and obtain the raw calculations it performs for decisions
        public void SaveTreeFunction()
        {
            var da = AppDomain.CurrentDomain.DefineDynamicAssembly(
                new AssemblyName("dyn"), // call it whatever you want
                AssemblyBuilderAccess.Save);

            var dm = da.DefineDynamicModule("dyn_mod", "dyn.dll");
            var dt = dm.DefineType("dyn_type");
            var method = dt.DefineMethod(
                            "Foo",
                             MethodAttributes.Public | MethodAttributes.Static);

            tree.ToExpression().CompileToMethod(method);
            dt.CreateType();

            da.Save("dyn.dll");
        }

    }
}
