using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            "Array Size", "Runs", "Array Type", "Insertion Sort", "Shell Sort",
            "Heap Sort", "Merge Sort", "Quick Sort", "Parallel Merge Sort"
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
            codebook = new Codification(Table);
            Symbols = codebook.Apply(Table);
            Inputs = Symbols.ToArray(inputColumns);
            Outputs = Symbols.ToArray<int>(outputColumn);
        }

        // Loads up the Decision Tree
        public void CreateDecisionTree()
        {
            var attributes = DecisionVariable.FromCodebook(codebook, inputColumns);
            tree = new DecisionTree(attributes, 6);
        }

        // Returns Error as a percentage. Best is 0.0, Worst is 1.0
        public double Learn()
        {
            c45 = new C45Learning(tree);
            return c45.Run(Inputs, Outputs);
        }

        // Actual Selection using Decision Tree
        public string GetBestAlgorithmForInput(double[] input)
        {
            int result = tree.Compute(input);
            string bestAlgorithm = codebook.Translate("Selected Sorting Algorithm", result);
            return bestAlgorithm;
        }

    }
}
