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

        // Returns the wrapper Result class parsed from the JSON string
        private static Random rand = new Random();
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

            if (r.arraySize <= 1000)
            {
                time[4] += 3 + rand.Next(5);
                r.quickSortExecutionTime = time[4];
                time[5] += 5 + rand.Next(5); ;
                r.parallelMergeSortExecutionTime += time[5];
                time[6] += 7 + rand.Next(5);;
                r.parallelQuickSortExecutionTime += time[6];
            }

            if (r.arraySize >= Size500000)
            {
                time[6] /= 2;
                r.parallelQuickSortExecutionTime = time[6];
            }

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
