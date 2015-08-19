using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Project___Adaptive_Sorting_Algorithm.Classes
{
    public class MergeSort: Sortable
    {
        public override void sort(ref int[] data)
        {
            new MergeSort().Sort(data);
        }

        #region Constants
        private const Int32 mergesDefault = 6;
        private const Int32 insertionLimitDefault = 12;
        #endregion

        #region Properties
        protected Int32[] Positions { get; set; }

        private Int32 merges;
        public Int32 Merges
        {
            get { return merges; }
            set
            {
                // A minimum of 2 merges are required
                if (value > 1)
                    merges = value;
                else
                    throw new ArgumentOutOfRangeException();

                if (Positions == null || Positions.Length != merges)
                    Positions = new Int32[merges];
            }
        }

        public Int32 InsertionLimit { get; set; }
        #endregion

        #region Constructors
        public MergeSort(Int32 merges, Int32 insertionLimit)
        {
            Merges = merges;
            InsertionLimit = insertionLimit;
        }

        public MergeSort()
          : this(mergesDefault, insertionLimitDefault)
        {
        }
        #endregion

        #region Sort Methods
        public void Sort(int[] entries)
        {
            // Allocate merge buffer
            var entries2 = new int[entries.Length];
            Sort(entries, entries2, 0, entries.Length - 1);
        }

        // Top-Down K-way Merge Sort
        public void Sort(int[] entries1, int[] entries2, Int32 first, Int32 last)
        {
            var length = last + 1 - first;
            if (length < 2)
                return;
            else if (length < InsertionLimit)
            {
                InsertionSort<int>.Sort(entries1, first, last);
                return;
            }

            var left = first;
            var size = ceiling(length, Merges);
            for (var remaining = length; remaining > 0; remaining -= size, left += size)
            {
                var right = left + Math.Min(remaining, size) - 1;
                Sort(entries1, entries2, left, right);
            }

            Merge(entries1, entries2, first, last);
            Array.Copy(entries2, first, entries1, first, length);
        }
        #endregion

        #region Merge Methods
        public void Merge(int[] entries1, int[] entries2, Int32 first, Int32 last)
        {
            Array.Clear(Positions, 0, Merges);
            // This implementation has a quadratic time dependency on the number of merges
            for (var index = first; index <= last; index++)
                entries2[index] = remove(entries1, first, last);
        }

        private int remove(int[] entries, Int32 first, Int32 last)
        {
            var entry = default(int);
            var found = (Int32?)null;
            var length = last + 1 - first;

            var index = 0;
            var left = first;
            var size = ceiling(length, Merges);
            for (var remaining = length; remaining > 0; remaining -= size, left += size, index++)
            {
                var position = Positions[index];
                if (position < Math.Min(remaining, size))
                {
                    var next = entries[left + position];
                    if (!found.HasValue || entry.CompareTo(next) > 0)
                    {
                        found = index;
                        entry = next;
                    }
                }
            }

            // Remove entry
            Positions[found.Value]++;
            return entry;
        }
        #endregion

        #region Math Methods
        private static Int32 ceiling(Int32 numerator, Int32 denominator)
        {
            return (numerator + denominator - 1) / denominator;
        }
        #endregion
    }
    #region Insertion Sort
    static class InsertionSort<T> where T : IComparable
    {
        public static void Sort(T[] entries, Int32 first, Int32 last)
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
