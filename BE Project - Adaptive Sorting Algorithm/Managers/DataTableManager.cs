using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.Math;
using Accord.Statistics.Filters;

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

        private DecisionTree tree;
        private C45Learning c45;

        // Labels for the DataTable
        private string[] inputColumns =
        {
            "Array Size", "Runs", "Array Type", "Insertion Sort (\u03BCs)", "Shell Sort (\u03BCs)",
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
                r.arraySize + "", r.runs + "", r.arraytype, r.insertionSortExecutionTime + "",
                r.shellSortExecutionTime + "", r.heapSortExecutionTime + "", r.mergeSortExecutionTime + "",
                r.quickSortExecutionTime + "", r.parallelMergeSortExecutionTime + "", r.bestClass
            };
            Table.Rows.Add(sr);
        }

        // Convert Data Table of strings into double[] inputs and int output
        // Constructs the Symbol table
        public void Codify()
        {
            string[] cols = { "Array Size", "Runs", "Selected Sorting Algorithm" };
            string[] cols_ip = { "Array Size", "Runs" };
            string cols_op = "Selected Sorting Algorithm";
            codebook = new Codification(Table, cols);
            Symbols = codebook.Apply(Table);
            Inputs = Symbols.ToArray(cols_ip);
            Outputs = Symbols.ToArray<int>(cols_op);
        }

        // Loads up the Decision Tree
        public void CreateDecisionTree()
        {
            string[] cols = { "Array Size", "Runs" };
            var attributes = DecisionVariable.FromCodebook(codebook, cols);
            tree = new DecisionTree(attributes, 6);
        }

        // Returns Error as a percentage. Best is 0.0, Worst is 1.0
        public double Learn()
        {
            c45 = new C45Learning(tree);
            return c45.Run(Inputs, Outputs);
        }

        
        // Actual Selection using Decision Tree
        public string GetBestAlgorithmForInput(string[] input, bool returnNonTranslatedInt)
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

    }
}
