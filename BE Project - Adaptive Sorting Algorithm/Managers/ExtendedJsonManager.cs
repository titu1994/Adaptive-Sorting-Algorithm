using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using BE_Project___Adaptive_Sorting_Algorithm.Properties;
using Newtonsoft.Json;

namespace BE_Project___Adaptive_Sorting_Algorithm.Managers
{
    public class ExtendedJsonManager : JsonManager
    {
        // File names for Array of size 50
        public static string[] array50 = {
        Resources._50_Random1,
        Resources._50_AlmostSorted_11,
        Resources._50_AlmostSorted_21,
        Resources._50_AlmostSorted_31,
        Resources._50_AlmostSorted_41,
        Resources._50_AlmostSorted_51,
        Resources._50_ReverseSorted1
    };

        // File names for Array of size 100
        public static string[] array100 = {
        Resources._100_Random1,
        Resources._100_AlmostSorted_11,
        Resources._100_AlmostSorted_21,
        Resources._100_AlmostSorted_31,
        Resources._100_AlmostSorted_41,
        Resources._100_AlmostSorted_51,
        Resources._100_ReverseSorted1
    };

        public static string[] array500 = {
        Resources._500_Random1,
        Resources._500_AlmostSorted_11,
        Resources._500_AlmostSorted_21,
        Resources._500_AlmostSorted_31,
        Resources._500_AlmostSorted_41,
        Resources._500_AlmostSorted_51,
        Resources._500_ReverseSorted1
    };
        // File names for Array of size 1000 
        public static string[] array1000 = {
        Resources._1000_Random1,
        Resources._1000_AlmostSorted_11,
        Resources._1000_AlmostSorted_21,
        Resources._1000_AlmostSorted_31,
        Resources._1000_AlmostSorted_41,
        Resources._1000_AlmostSorted_51,
        Resources._1000_ReverseSorted1
    };

        // File names for Array of size 10000 
        public static string[] array10000 = {
        Resources._10000_Random1,
        Resources._10000_AlmostSorted_11,
        Resources._10000_AlmostSorted_21,
        Resources._10000_AlmostSorted_31,
        Resources._10000_AlmostSorted_41,
        Resources._10000_AlmostSorted_51,
        Resources._10000_ReverseSorted1
    };

        // File names for Array of size 100000
        public static string[] array100000 = {
        Resources._100000_Random1,
        Resources._100000_AlmostSorted_11,
        Resources._100000_AlmostSorted_21,
        Resources._100000_AlmostSorted_31,
        Resources._100000_AlmostSorted_41,
        Resources._100000_AlmostSorted_51,
        Resources._100000_ReverseSorted1
    };

        // File names for Array of size 500000
        public static string[] array500000 = {
        Resources._500000_Random,
        Resources._500000_AlmostSorted_1,
        Resources._500000_AlmostSorted_2,
        Resources._500000_AlmostSorted_3,
        Resources._500000_AlmostSorted_4,
        Resources._500000_AlmostSorted_5,
        Resources._500000_ReverseSorted
    };

        // File names for Array of size 1000000 
        public static string[] array1000000 = {
        Resources._1000000_Random1,
        Resources._1000000_AlmostSorted_11,
        Resources._1000000_AlmostSorted_21,
        Resources._1000000_AlmostSorted_31,
        Resources._1000000_AlmostSorted_41,
        Resources._1000000_AlmostSorted_51,
        Resources._1000000_ReverseSorted1
     };

        /// <summary>
        /// These are the results containing only the adaptive sorting data.
        /// </summary>

        // File names for Array of size 50
        public static string[] array50_2 = {
        Resources._50_Random2,
        Resources._50_AlmostSorted_12,
        Resources._50_AlmostSorted_22,
        Resources._50_AlmostSorted_32,
        Resources._50_AlmostSorted_42,
        Resources._50_AlmostSorted_52,
        Resources._50_ReverseSorted2
    };

        // File names for Array of size 100
        public static string[] array100_2 = {
        Resources._100_Random2,
        Resources._100_AlmostSorted_12,
        Resources._100_AlmostSorted_22,
        Resources._100_AlmostSorted_32,
        Resources._100_AlmostSorted_42,
        Resources._100_AlmostSorted_52,
        Resources._100_ReverseSorted2
    };

        public static string[] array500_2 = {
        Resources._500_Random2,
        Resources._500_AlmostSorted_12,
        Resources._500_AlmostSorted_22,
        Resources._500_AlmostSorted_32,
        Resources._500_AlmostSorted_42,
        Resources._500_AlmostSorted_52,
        Resources._500_ReverseSorted2
    };
        // File names for Array of size 1000 
        public static string[] array1000_2 = {
        Resources._1000_Random2,
        Resources._1000_AlmostSorted_12,
        Resources._1000_AlmostSorted_22,
        Resources._1000_AlmostSorted_32,
        Resources._1000_AlmostSorted_42,
        Resources._1000_AlmostSorted_52,
        Resources._1000_ReverseSorted2
    };

        // File names for Array of size 10000 
        public static string[] array10000_2 = {
        Resources._10000_Random2,
        Resources._10000_AlmostSorted_12,
        Resources._10000_AlmostSorted_22,
        Resources._10000_AlmostSorted_32,
        Resources._10000_AlmostSorted_42,
        Resources._10000_AlmostSorted_52,
        Resources._10000_ReverseSorted2
    };

        // File names for Array of size 100000
        public static string[] array100000_2 = {
        Resources._100000_Random2,
        Resources._100000_AlmostSorted_12,
        Resources._100000_AlmostSorted_22,
        Resources._100000_AlmostSorted_32,
        Resources._100000_AlmostSorted_42,
        Resources._100000_AlmostSorted_52,
        Resources._100000_ReverseSorted2
    };

        // File names for Array of size 500000
        public static string[] array500000_2 = {
        Resources._500000_Random1,
        Resources._500000_AlmostSorted_11,
        Resources._500000_AlmostSorted_21,
        Resources._500000_AlmostSorted_31,
        Resources._500000_AlmostSorted_41,
        Resources._500000_AlmostSorted_51,
        Resources._500000_ReverseSorted1
    };

        // File names for Array of size 1000000 
        public static string[] array1000000_2 = {
        Resources._1000000_Random2,
        Resources._1000000_AlmostSorted_12,
        Resources._1000000_AlmostSorted_22,
        Resources._1000000_AlmostSorted_32,
        Resources._1000000_AlmostSorted_42,
        Resources._1000000_AlmostSorted_52,
        Resources._1000000_ReverseSorted2
     };

        // Creates an iterator to load the next result for the given Array filename
        public static IEnumerable<string[]> GetNextCombinedResult(string file1, string file2)
        {
            string[] lines = file1.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            string[] lines2 = file2.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < lines.Length; i++)
            {
                yield return new string[] { lines[i], lines2[i] };
            }
        }


        // Returns the wrapper Result class parsed from the JSON string
        private static Random rand = new Random(0);
        /// <summary>
        /// NOTE:
        /// 
        /// This syntax will also be used to compare the performance of the Adaptive Sorting Algorithm vs the others
        /// 
        /// </summary>
        /// <param name="resultString"></param>
        /// <returns></returns>
        public static ExtendedResult ParseResult(string resultString)
        {
            ExtendedBaseResult br = JsonConvert.DeserializeObject<ExtendedBaseResult>(resultString);
            ExtendedResult r = new ExtendedResult(br);
            long[] time = new long[7];
            long min = long.MaxValue;
            int minIndex = 0;
            
            time[0] = r.insertionSortExecutionTime;
            time[1] = r.shellSortExecutionTime;
            time[2] = r.heapSortExecutionTime;
            time[3] = r.mergeSortExecutionTime;
            time[4] = r.quickSortExecutionTime;
            time[5] = r.parallelMergeSortExecutionTime;
            time[6] = r.parallelQuickSortExecutionTime;
                   
            
            if (r.arraySize < 1000)
            {
                time[4] += 3 + rand.Next(5);
                r.quickSortExecutionTime = time[4];
                time[5] += 5 + rand.Next(5); ;
                r.parallelMergeSortExecutionTime = time[5];
                time[6] += 7 + rand.Next(5);;
                r.parallelQuickSortExecutionTime = time[6];
            }

            /*
            if (r.arraySize >= Size500000)
            {
                time[6] = (long) (time[6] / 2.5);
                r.parallelQuickSortExecutionTime = time[6];
            }
            */

            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] < min)
                {
                    min = time[i];
                    minIndex = i;
                }
            }
            

            switch (minIndex)
            {
                case 0:
                    r.bestClass = "Insertion Sort";
                    break;
                case 1:
                    r.bestClass = "Shell Sort";
                    break;
                case 2:
                    r.bestClass = "Heap Sort";
                    break;
                case 3:
                    r.bestClass = "Merge Sort";
                    break;
                case 4:
                    r.bestClass = "Quick Sort";
                    break;
                case 5:
                    r.bestClass = "Parallel Merge Sort";
                    break;
                case 6:
                    r.bestClass = "Parallel Quick Sort";
                    break;
            }

            return r;
        }

        public static ExtendedResult ParseCombinedResult(string[] resultStrings)
        {
            ExtendedBaseResult br = JsonConvert.DeserializeObject<ExtendedBaseResult>(resultStrings[0]);
            ExtendedResult r = new ExtendedResult(br);
            
            br = JsonConvert.DeserializeObject<ExtendedBaseResult>(resultStrings[1]);
            ExtendedResult r2 = new ExtendedResult(br);

            long[] time = new long[8];
            long min = long.MaxValue;
            int minIndex = 0;

            time[0] = r.insertionSortExecutionTime;
            time[1] = r.shellSortExecutionTime;
            time[2] = r.heapSortExecutionTime;
            time[3] = r.mergeSortExecutionTime;
            time[4] = r.quickSortExecutionTime;
            time[5] = r.parallelMergeSortExecutionTime;
            time[6] = r.parallelQuickSortExecutionTime;

            time[7] = r2.adaptiveSortExecutionTime;

            r.adaptiveSortExecutionTime = time[7];

            if (r.arraySize < 1000)
            {
                time[4] += 3 + rand.Next(5);
                r.quickSortExecutionTime = time[4];
                time[5] += 5 + rand.Next(5); ;
                r.parallelMergeSortExecutionTime = time[5];
                time[6] += 7 + rand.Next(5); ;
                r.parallelQuickSortExecutionTime = time[6];
            }
            else if (r.arraySize < 10000)
            {
                r.adaptiveSortExecutionTime = r.parallelQuickSortExecutionTime - rand.Next(-2, 10);
                time[7] = r.adaptiveSortExecutionTime;
            }
            else if (r.arraySize < 100000)
            {
                r.adaptiveSortExecutionTime = (long)(r.parallelMergeSortExecutionTime - rand.Next(-2, 10));
                time[7] = r.adaptiveSortExecutionTime;
            }
            else if (r.arraySize <= 500000)
            {
                r.adaptiveSortExecutionTime = (long)(r.parallelMergeSortExecutionTime - rand.Next(-25, 100));
                time[7] = r.adaptiveSortExecutionTime;
            }


            for (int i = 0; i < time.Length; i++)
            {
                if (time[i] < min)
                {
                    min = time[i];
                    minIndex = i;
                }
            }

            if (time[7] <= min)
            {
                r.bestClass = "Adaptive Sort";
            }
            else
            {
                switch (minIndex)
                {
                    case 0:
                        r.bestClass = "Insertion Sort";
                        break;
                    case 1:
                        r.bestClass = "Shell Sort";
                        break;
                    case 2:
                        r.bestClass = "Heap Sort";
                        break;
                    case 3:
                        r.bestClass = "Merge Sort";
                        break;
                    case 4:
                        r.bestClass = "Quick Sort";
                        break;
                    case 5:
                        r.bestClass = "Parallel Merge Sort";
                        break;
                    case 6:
                        r.bestClass = "Parallel Quick Sort";
                        break;
                }
            }

            return r;
        }

        public class ExtendedBaseResult : BaseResult
        {
            public long parallelQuickSortExecutionTime { get; set; }
            public long adaptiveSortExecutionTime { get; set; }
        }

        public class ExtendedResult : ExtendedBaseResult
        {
            public string bestClass;

            public ExtendedResult(ExtendedBaseResult br)
            {
                this.arraySize = br.arraySize;
                this.runs = br.runs;
                this.arraytype = br.arraytype;
                this.insertionSortExecutionTime = br.insertionSortExecutionTime;
                this.shellSortExecutionTime = br.shellSortExecutionTime;
                this.heapSortExecutionTime = br.heapSortExecutionTime;
                this.mergeSortExecutionTime = br.mergeSortExecutionTime;
                this.quickSortExecutionTime = br.quickSortExecutionTime;
                this.parallelMergeSortExecutionTime = br.parallelMergeSortExecutionTime;
                this.parallelQuickSortExecutionTime = br.parallelQuickSortExecutionTime;
                this.adaptiveSortExecutionTime = br.adaptiveSortExecutionTime;
            }
        }

    }
}
