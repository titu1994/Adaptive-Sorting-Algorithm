using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Project___Adaptive_Sorting_Algorithm.Classes
{
    class QuickSort : Sortable
    {
        public override void sort(ref int[] data)
        {
            new QuickSort().Sort(data);
        }

        #region Constants
        private const Int32 insertionLimitDefault = 16;
        private const Int32 pivotSamples = 5;
        #endregion

        #region Properties
        public Int32 InsertionLimit { get; set; }
        protected Random Random { get; set; }
        #endregion

        #region Constructors
        public QuickSort()
          : this(insertionLimitDefault, new Random())
        {
        }

        public QuickSort(Int32 insertionLimit, Random random)
        {
            InsertionLimit = insertionLimit;
            Random = random;
        }
        #endregion

        #region Sort Methods
        public void Sort(int[] entries)
        {
            Sort(entries, 0, entries.Length - 1);
        }

        public void Sort(int[] entries, Int32 first, Int32 last)
        {
            var length = last + 1 - first;
            // Elide tail recursion by looping over the longer partition
            while (length > 1)
            {
                if (length < InsertionLimit)
                {
                    InsertionSort.Sort(entries, first, last);
                    return;
                }

                var median = pivot(entries, first, last);

                var left = first;
                var right = last;
                partition(entries, median, ref left, ref right);

                var leftLength = right + 1 - first;
                var rightLength = last + 1 - left;

                if (leftLength < rightLength)
                {
                    Sort(entries, first, right);
                    first = left;
                    length = rightLength;
                }
                else
                {
                    Sort(entries, left, last);
                    last = right;
                    length = leftLength;
                }
            }
        }

        private int pivot(int[] entries, Int32 first, Int32 last)
        {
            var length = last + 1 - first;
            var sampleSize = Math.Min(pivotSamples, length);
            var right = first + sampleSize - 1;
            for (var left = first; left <= right; left++)
            {
                // Random sampling avoids pathological cases
                var random = Random.Next(left, last + 1);
                // Sample without replacement
                if (left != random)
                    Swap(entries, left, random);
            }

            InsertionSort.Sort(entries, first, right);
            return entries[first + sampleSize / 2];
        }

        private static void partition(int[] entries, int pivot, ref Int32 left, ref Int32 right)
        {
            while (left <= right)
            {
                while (pivot.CompareTo(entries[left]) > 0)
                    left++;                       // pivot follows entry
                while (pivot.CompareTo(entries[right]) < 0)
                    right--;                      // pivot precedes entry

                if (left < right)               // Move entries to their correct partition
                    Swap(entries, left++, right--);
                else if (left == right)
                {       // No swap needed
                    left++;
                    right--;
                }
            }
        }

        public static void Swap(int[] entries, Int32 index1, Int32 index2)
        {
            var entry = entries[index1];
            entries[index1] = entries[index2];
            entries[index2] = entry;
        }
        #endregion
    }

    #region Insertion Sort

    partial class InsertionSort
    {
        public static void Sort(int[] entries, Int32 first, Int32 last)
        {
            for (var i = first + 1; i <= last; i++)
            {
                var entry = entries[i];
                var j = i;
                while (j > first && entries[j - 1].CompareTo(entry) > 0)
                    entries[j] = entries[--j];
                entries[j] = entry;
            }
        }
    }
    #endregion
}
