﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

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

        private string[] inputColumnsWithAdaptiveSort =
        {
            "Array Size", "Runs", /*"Array Type",*/ "Insertion Sort (\u03BCs)", "Shell Sort (\u03BCs)",
            "Heap Sort (\u03BCs)", "Merge Sort (\u03BCs)", "Quick Sort (\u03BCs)", "Parallel Merge Sort (\u03BCs)",
            "Parallel Quick Sort (\u03BCs)", "Adaptive Sort (\u03BCs)"
        };

        public ExtendedDataTableManager() 
        {
            Table = new DataTable("Sorting Table");
            foreach (string t in inputColumns)
                Table.Columns.Add(t);
            Table.Columns.Add(outputColumn);
        }

        public ExtendedDataTableManager(bool withAdaptiveSortData)
        {
            Table = new DataTable("Sorting Table");
            foreach (string t in inputColumnsWithAdaptiveSort)
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

        // Add each result one by one
        public void AddResultWithAdaptiveSort(ExtendedJsonManager.ExtendedResult r)
        {
            object[] sr =
            {
                r.arraySize + "", r.runs + "", /*r.arraytype,*/  r.insertionSortExecutionTime + "",
                r.shellSortExecutionTime + "", r.heapSortExecutionTime + "", r.mergeSortExecutionTime + "",
                r.quickSortExecutionTime + "", r.parallelMergeSortExecutionTime + "", r.parallelQuickSortExecutionTime, r.adaptiveSortExecutionTime , r.bestClass
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

        public void LoadAllResultsWithAdaptiveData(bool saveToFile = false, bool marginOfDifference = false)
        {
            string filename, filename2;
            string[][] arrays = { ExtendedJsonManager.array100, ExtendedJsonManager.array1000, ExtendedJsonManager.array10000,
                ExtendedJsonManager.array100000, ExtendedJsonManager.array500000,
                ExtendedJsonManager.array1000000 };

            string[][] arraysOfAdaptiveData = { ExtendedJsonManager.array100_2, ExtendedJsonManager.array1000_2, ExtendedJsonManager.array10000_2,
                ExtendedJsonManager.array100000_2, ExtendedJsonManager.array500000_2,
                ExtendedJsonManager.array1000000_2 };

            ExtendedJsonManager.ExtendedResult result;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/CSV Data/";
            string fn = "Results.csv";
            StreamWriter writer = null;

            if (saveToFile)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                writer = new StreamWriter(path + fn)
                {
                    AutoFlush = true
                };
                writer.WriteLine("Array Size,Runs,Insertion Sort,Shell Sort,Heap Sort,Merge Sort,Quick Sort,Parallel Merge Sort,Parallel Quick Sort,Adaptive Sort,Best Algorithm");
            }

            string resultLine = "";

            for (int i = 0; i < arrays.Length; i++)
            {
                for (int j = 0; j < arrays[i].Length; j++)
                {
                    filename = arrays[i][j];
                    filename2 = arraysOfAdaptiveData[i][j];
                    foreach (string[] jsons in ExtendedJsonManager.GetNextCombinedResult(filename, filename2))
                    {
                        result = ExtendedJsonManager.ParseCombinedResult(jsons, allowMarginOfDifference: marginOfDifference);

                        if (saveToFile)
                        {
                            resultLine = result.arraySize + "," +
                                         result.runs + "," +
                                         result.insertionSortExecutionTime + "," + 
                                         result.shellSortExecutionTime + "," + 
                                         result.heapSortExecutionTime + "," + 
                                         result.mergeSortExecutionTime + "," +
                                         result.quickSortExecutionTime + "," + 
                                         result.parallelMergeSortExecutionTime + "," +
                                         result.parallelQuickSortExecutionTime + "," +
                                         result.adaptiveSortExecutionTime + ",'" +
                                         result.bestClass + "'";
                            
                            writer.WriteLine(resultLine);
                        }

                        AddResultWithAdaptiveSort(result);
                    }
                }
            }

            if (saveToFile)
            {
                writer.Flush();
                writer.Close();
            }
            
        }


    }
}
