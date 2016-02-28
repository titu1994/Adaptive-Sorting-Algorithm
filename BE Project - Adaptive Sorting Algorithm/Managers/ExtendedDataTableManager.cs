using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Project___Adaptive_Sorting_Algorithm.Managers
{
    class ExtendedDataTableManager : DataTableManager
    {
        // Labels for the DataTable
        private string[] inputColumns =
        {
            "Array Size", "Runs", /*"Array Type",*/ "Insertion Sort (\u03BCs)", "Shell Sort (\u03BCs)",
            "Heap Sort (\u03BCs)", "Merge Sort (\u03BCs)", "Quick Sort (\u03BCs)", "Parallel Merge Sort (\u03BCs)",
            "Parallel Quick Sort (\u03BCs)"
        };

        public ExtendedDataTableManager() 
        {
            Table = new DataTable("Sorting Table");
            foreach (string t in inputColumns)
                Table.Columns.Add(t);
            Table.Columns.Add(outputColumn);
        }

        // Add each result one by one
        public void AddResult(ExtendedJsonManager.ExtendedResult r)
        {
            object[] sr =
            {
                r.arraySize + "", r.runs + "", /*r.arraytype,*/  r.insertionSortExecutionTime + "",
                r.shellSortExecutionTime + "", r.heapSortExecutionTime + "", r.mergeSortExecutionTime + "",
                r.quickSortExecutionTime + "", r.parallelMergeSortExecutionTime + "", r.parallelQuickSortExecutionTime, r.bestClass
            };
            Table.Rows.Add(sr);
        }

        // Load the Data Table with all of the JSONManager data
        public void LoadAllResults()
        {
            string line;
            string filename;
            string[][] arrays = { ExtendedJsonManager.array100, ExtendedJsonManager.array1000, ExtendedJsonManager.array10000,
                ExtendedJsonManager.array100000, ExtendedJsonManager.array500000,
                ExtendedJsonManager.array1000000 };
            ExtendedJsonManager.ExtendedResult result;

            foreach (string[] t in arrays)
            {
                foreach (string t1 in t)
                {
                    filename = t1;

                    foreach (string json in JsonManager.GetNextResult(filename))
                    {
                        result = ExtendedJsonManager.ParseResult(json);
                        AddResult(result);
                    }
                }
            }
        }



    }
}
