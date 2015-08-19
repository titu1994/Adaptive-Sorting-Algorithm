using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Project___Adaptive_Sorting_Algorithm.Properties;

namespace BE_Project___Adaptive_Sorting_Algorithm.Classes
{
    class ArrayManager
    {
        private static readonly string[] array100 = {Resources.Array_100_Random,
            Resources.Array_100_Almost_Sorted_0_1, Resources.Array_100_Almost_Sorted_0_2, Resources.Array_100_Almost_Sorted_0_33,
            Resources.Array_100_Almost_Sorted_0_4, Resources.Array_100_Almost_Sorted_0_5, Resources.Array_100_Reverse_Sorted};

        private static readonly string[] array1000 = {Resources.Array_1000_Random,
            Resources.Array_1000_Almost_Sorted_0_1, Resources.Array_1000_Almost_Sorted_0_2, Resources.Array_1000_Almost_Sorted_0_33,
            Resources.Array_1000_Almost_Sorted_0_4, Resources.Array_1000_Almost_Sorted_0_5, Resources.Array_1000_Reverse_Sorted};

        private static readonly string[] array10000 = {Resources.Array_10000_Random,
            Resources.Array_10000_Almost_Sorted_0_1, Resources.Array_10000_Almost_Sorted_0_2, Resources.Array_10000_Almost_Sorted_0_33,
            Resources.Array_10000_Almost_Sorted_0_4, Resources.Array_10000_Almost_Sorted_0_5, Resources.Array_10000_Reverse_Sorted};


        private static readonly int RANDOM_SORTED_INDEX = 0;
        private static readonly int ALMOST_SORTED_INDEX_1 = 1;
        private static readonly int ALMOST_SORTED_INDEX_2 = 2;
        private static readonly int ALMOST_SORTED_INDEX_3 = 3;
        private static readonly int ALMOST_SORTED_INDEX_4 = 4;
        private static readonly int ALMOST_SORTED_INDEX_5 = 5;
        private static readonly int REVERSE_SORTED_INDEX = 6;

        public static int SIZE_100 = 100;
        public static int SIZE_1000 = 1000;
        public static int SIZE_10000 = 10000;

        public static IEnumerable<int[]> GetNextArray(string filename)
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                var line = "";
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Substring(1, line.Length - 1);
                    var hold = line.Split(',').Select(i => Convert.ToInt32(i)).ToArray();
                    yield return hold;
                }
            }
        }

        public static int[] CopyArray(ref int[] x)
        {
            int[] result = new int[x.Length];
            Array.Copy(x, result, 0);
            return result;
        }

        public static double ComputeRuns(ref int[] data)
        {
            double runs = 0;
            int n = data.Length;
            int subsetCount = 1;

            for (int i = 1; i < n; i++)
            {
                if (data[i - 1] > data[i])
                    subsetCount++;
            }
            runs = subsetCount/(double) n;
            return runs;
        }

        public static string GetRandomArrayOfSize(int size)
        {
            switch (size)
            {
                case 100:
                    return array100[RANDOM_SORTED_INDEX];
                case 1000:
                    return array1000[RANDOM_SORTED_INDEX];
                case 10000:
                    return array10000[RANDOM_SORTED_INDEX];
            }
            return array100[RANDOM_SORTED_INDEX];
        }

        public static string GetReversedArrayOfSize(int size)
        {
            switch (size)
            {
                case 100:
                    return array100[REVERSE_SORTED_INDEX];
                case 1000:
                    return array1000[REVERSE_SORTED_INDEX];
                case 10000:
                    return array10000[REVERSE_SORTED_INDEX];
            }
            return array100[RANDOM_SORTED_INDEX];
        }

        public static string GetAlmostSortedArrayOfSize(int size, int preSortednessDegree)
        {
            switch (size)
            {
                case 100:
                    switch (preSortednessDegree)
                    {
                        case 1: 
                            return array100[ALMOST_SORTED_INDEX_1];
                        case 2:
                            return array100[ALMOST_SORTED_INDEX_2];
                        case 3:
                            return array100[ALMOST_SORTED_INDEX_3];
                        case 4:
                            return array100[ALMOST_SORTED_INDEX_4];
                        case 5:
                            return array100[ALMOST_SORTED_INDEX_5];
                    }
                    return array100[ALMOST_SORTED_INDEX_1];
                case 1000:
                    switch (preSortednessDegree)
                    {
                        case 1:
                            return array1000[ALMOST_SORTED_INDEX_1];
                        case 2:
                            return array1000[ALMOST_SORTED_INDEX_2];
                        case 3:
                            return array1000[ALMOST_SORTED_INDEX_3];
                        case 4:
                            return array1000[ALMOST_SORTED_INDEX_4];
                        case 5:
                            return array1000[ALMOST_SORTED_INDEX_5];
                    }
                    return array1000[ALMOST_SORTED_INDEX_1];
                case 10000:
                    switch (preSortednessDegree)
                    {
                        case 1:
                            return array10000[ALMOST_SORTED_INDEX_1];
                        case 2:
                            return array10000[ALMOST_SORTED_INDEX_2];
                        case 3:
                            return array10000[ALMOST_SORTED_INDEX_3];
                        case 4:
                            return array10000[ALMOST_SORTED_INDEX_4];
                        case 5:
                            return array10000[ALMOST_SORTED_INDEX_5];
                    }
                    return array10000[ALMOST_SORTED_INDEX_1];
            }
            return array100[ALMOST_SORTED_INDEX_1];
        }
    }
}
