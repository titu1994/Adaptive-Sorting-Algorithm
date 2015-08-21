using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Project___Adaptive_Sorting_Algorithm.Properties;
using Newtonsoft.Json;

namespace BE_Project___Adaptive_Sorting_Algorithm.Managers
{
    class JsonManager
    {
        // File names for Array of size 100
        private static string[] array100 = {
        Encoding.UTF8.GetString(Resources._100_Random),
        Encoding.UTF8.GetString(Resources._100_AlmostSorted_1),
        Encoding.UTF8.GetString(Resources._100_AlmostSorted_2),
        Encoding.UTF8.GetString(Resources._100_AlmostSorted_3),
        Encoding.UTF8.GetString(Resources._100_AlmostSorted_4),
        Encoding.UTF8.GetString(Resources._100_AlmostSorted_5),
        Encoding.UTF8.GetString(Resources._100_ReverseSorted)
    };
        // File names for Array of size 1000 
        private static string[] array1000 = {
        Encoding.UTF8.GetString(Resources._1000_Random),
        Encoding.UTF8.GetString(Resources._1000_AlmostSorted_1),
        Encoding.UTF8.GetString(Resources._1000_AlmostSorted_2),
        Encoding.UTF8.GetString(Resources._1000_AlmostSorted_3),
        Encoding.UTF8.GetString(Resources._1000_AlmostSorted_4),
        Encoding.UTF8.GetString(Resources._1000_AlmostSorted_5),
        Encoding.UTF8.GetString(Resources._1000_ReverseSorted)
    };

        // File names for Array of size 10000 
        private static string[] array10000 = {
        Encoding.UTF8.GetString(Resources._10000_Random),
        Encoding.UTF8.GetString(Resources._10000_AlmostSorted_1),
        Encoding.UTF8.GetString(Resources._10000_AlmostSorted_2),
        Encoding.UTF8.GetString(Resources._10000_AlmostSorted_3),
        Encoding.UTF8.GetString(Resources._10000_AlmostSorted_4),
        Encoding.UTF8.GetString(Resources._10000_AlmostSorted_5),
        Encoding.UTF8.GetString(Resources._10000_ReverseSorted)
    };

        // File names for Array of size 1000000 
        private static string[] array1000000 = {
        Encoding.UTF8.GetString(Resources._1000000_Random),
        Encoding.UTF8.GetString(Resources._1000000_AlmostSorted_1),
        Encoding.UTF8.GetString(Resources._1000000_AlmostSorted_2),
        Encoding.UTF8.GetString(Resources._1000000_AlmostSorted_3),
        Encoding.UTF8.GetString(Resources._1000000_AlmostSorted_4),
        Encoding.UTF8.GetString(Resources._1000000_AlmostSorted_5),
        Encoding.UTF8.GetString(Resources._1000000_ReverseSorted)
     };


        // ARRAY TYPE: 
        public static int TypeRandom = 0; // Not sorted / Randomly arranged
        public static int TypeAlmostSorted1 = 1; // 10% sorted recurring fragments
        public static int TypeAlmostSorted2 = 2; // 20% sorted recurring fragments
        public static int TypeAlmostSorted3 = 3; // 33% sorted recurring fragments
        public static int TypeAlmostSorted4 = 4; // 40% sorted recurring fragments
        public static int TypeAlmostSorted5 = 5; // 50% sorted recurring fragments
        public static int TypeReverseSorted = 6; // Reverse sorted
        //END of ARRAY TYPES

        public static int Size100 = 100;
        public static int Size1000 = 1000;
        public static int Size10000 = 10000;
        public static int Size1000000 = 1000000;

        // Creates an iterator to load the next result for the given Array filename
        public static IEnumerable<string> GetNextResult(string filename)
        {
            string line;
            using (StreamReader reader = new StreamReader(filename))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }

        // Returns the wrapper Result class parsed from the JSON string
        public static Result ParseResult(string resultString)
        {
            BaseResult br = JsonConvert.DeserializeObject<BaseResult>(resultString);
            Result r = new Result(br);
            long[] time = new long[6];
            long min = long.MaxValue;
            int minIndex = 0;

            time[0] = r.insertionSortExecutionTime;
            time[1] = r.shellSortExecutionTime;
            time[2] = r.heapSortExecutionTime;
            time[3] = r.mergeSortExecutionTime;
            time[4] = r.quickSortExecutionTime;
            time[5] = r.parallelMergeSortExecutionTime;

            for (int i = 0; i < 6; i++)
            {
                if (time[i] < min)
                {
                    min = time[i];
                    minIndex = i;
                }
            }

            switch (minIndex)
            {
                case 0: r.bestClass = "Insertion Sort";
                    break;
                case 1: r.bestClass = "Shell Sort";
                    break;
                case 2: r.bestClass = "Heap Sort";
                    break;
                case 3: r.bestClass = "Merge Sort";
                    break;
                case 4: r.bestClass = "Quick Sort";
                    break;
                case 5: r.bestClass = "Parallel Quick Sort";
                    break;
            }

            return r;
        }

        // Helper method to obtain filename of Random array of some size
        public static string getRandomArrayOfSize(int size)
        {
            switch (size)
            {
                case 100:
                    return array100[TypeRandom];
                case 1000:
                    return array1000[TypeRandom];
                case 10000:
                    return array10000[TypeRandom];
                case 1000000:
                    return array1000000[TypeRandom];
            }
            return array100[TypeRandom];
        }

        // Helper method to obtain filename of Reverse Sorted array of some size
        public static string getReversedArrayOfSize(int size)
        {
            switch (size)
            {
                case 100:
                    return array100[TypeReverseSorted];
                case 1000:
                    return array1000[TypeReverseSorted];
                case 10000:
                    return array10000[TypeReverseSorted];
                case 1000000:
                    return array1000000[TypeReverseSorted];
            }
            return array100[TypeRandom];
        }

        // Helper method to obtain filename of Almost Sorted array of some size
        public static string getAlmostSortedArrayOfSize(int size, int preSortednessDegree)
        {
            switch (size)
            {
                case 100:
                    switch (preSortednessDegree)
                    {
                        case 1:
                            return array100[TypeAlmostSorted1];
                        case 2:
                            return array100[TypeAlmostSorted2];
                        case 3:
                            return array100[TypeAlmostSorted3];
                        case 4:
                            return array100[TypeAlmostSorted4];
                        case 5:
                            return array100[TypeAlmostSorted5];
                    }
                    return array100[TypeAlmostSorted1];
                case 1000:
                    switch (preSortednessDegree)
                    {
                        case 1:
                            return array1000[TypeAlmostSorted1];
                        case 2:
                            return array1000[TypeAlmostSorted2];
                        case 3:
                            return array1000[TypeAlmostSorted3];
                        case 4:
                            return array1000[TypeAlmostSorted4];
                        case 5:
                            return array1000[TypeAlmostSorted5];
                    }
                    return array1000[TypeAlmostSorted1];
                case 10000:
                    switch (preSortednessDegree)
                    {
                        case 1:
                            return array10000[TypeAlmostSorted1];
                        case 2:
                            return array10000[TypeAlmostSorted2];
                        case 3:
                            return array10000[TypeAlmostSorted3];
                        case 4:
                            return array10000[TypeAlmostSorted4];
                        case 5:
                            return array10000[TypeAlmostSorted5];
                    }
                    return array10000[TypeAlmostSorted1];
                case 1000000:
                    switch (preSortednessDegree)
                    {
                        case 1:
                            return array1000000[TypeAlmostSorted1];
                        case 2:
                            return array1000000[TypeAlmostSorted2];
                        case 3:
                            return array1000000[TypeAlmostSorted3];
                        case 4:
                            return array1000000[TypeAlmostSorted4];
                        case 5:
                            return array1000000[TypeAlmostSorted5];
                    }
                    return array1000000[TypeAlmostSorted1];
            }
            return array100[TypeAlmostSorted1];
        }

        // Wrapper class to parse the JSON string into an object
        public class BaseResult
        {
            public int arraySize { get; set; }
            public double runs { get; set; }
            public string arraytype { get; set; }
            public long insertionSortExecutionTime { get; set; }
            public long shellSortExecutionTime { get; set; }
            public long heapSortExecutionTime { get; set; }
            public long mergeSortExecutionTime { get; set; }
            public long quickSortExecutionTime { get; set; }
            public long parallelMergeSortExecutionTime { get; set; }

            public BaseResult() { }
        }

        // Wrapper of BaseResult to hold the calculation of the best algorithm for each array
        public class Result : BaseResult
        {
            public string bestClass;

            public Result(BaseResult br)
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
            }
        }
    }
}
