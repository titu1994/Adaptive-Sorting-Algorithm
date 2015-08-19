using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE_Project___Adaptive_Sorting_Algorithm.Classes;

namespace BE_Project___Adaptive_Sorting_Algorithm.Managers.SortableClasses
{
    public class ParallelQuickSort: Sortable
    {
        public static int Threshold = 150; // array length to use InsertionSort instead of SequentialQuickSort

        public override void sort(ref int[] data)
        {
            int p = (int)Math.Log(Environment.ProcessorCount, 2) + 4;
            int limit = 1 + data.Length/(p << 3);
            Threshold = p > 1 ? (limit > 150? limit: 150) : data.Length;
            Sort(data);
        }

        public static void InsertionSort(int[] array, int from, int to)
        {
            for (int i = from + 1; i < to; i++)
            {
                var a = array[i];
                int j = i - 1;
                while (j >= from && array[j] > a)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = a;
            }
        }

        static void Swap(int[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        static int Partition(int[] array, int from, int to, int pivot)
        {
            // Pre: from <= pivot < to (other than that, pivot is arbitrary)
            var arrayPivot = array[pivot];  // pivot value
            Swap(array, pivot, to - 1); // move pivot value to end for now, after this pivot not used
            var newPivot = from; // new pivot 
            for (int i = from; i < to - 1; i++) // be careful to leave pivot value at the end
            {
                // Invariant: from <= newpivot <= i < to - 1 && 
                // forall from <= j <= newpivot, array[j] <= arrayPivot && forall newpivot < j <= i, array[j] > arrayPivot
                if (array[i] <= arrayPivot)
                {
                    Swap(array, newPivot, i);  // move value smaller than arrayPivot down to newpivot
                    newPivot++;
                }
            }
            Swap(array, newPivot, to - 1); // move pivot value to its final place
            return newPivot; // new pivot
            // Post: forall i <= newpivot, array[i] <= array[newpivot]  && forall i > ...
        }

        public static void SequentialQuickSort(int[] array)
        {
            SequentialQuickSort(array, 0, array.Length);
        }

        static void SequentialQuickSort(int[] array, int from, int to)
        {
            if (to - from <= Threshold)
            {
                InsertionSort(array, from, to);
            }
            else
            {
                int pivot = from + (to - from) / 2; // could be anything, use middle
                pivot = Partition(array, from, to, pivot);
                // Assert: forall i < pivot, array[i] <= array[pivot]  && forall i > ...
                SequentialQuickSort(array, from, pivot);
                SequentialQuickSort(array, pivot + 1, to);
            }
        }

        private static void Sort(int[] array)
        {
            ParallelQuickSortMethod(array, 0, array.Length,
                 (int)Math.Log(Environment.ProcessorCount, 2) + 4);
        }

        private static void ParallelQuickSortMethod(int[] array, int from, int to, int depthRemaining)
        {
            if (to - from <= Threshold)
            {
                InsertionSort(array, from, to);
            }
            else
            {
                int pivot = from + (to - from) / 2; // could be anything, use middle
                pivot = Partition(array, from, to, pivot);
                if (depthRemaining > 0)
                {
                    Parallel.Invoke(
                        () => ParallelQuickSortMethod(array, from, pivot, depthRemaining - 1),
                        () => ParallelQuickSortMethod(array, pivot + 1, to, depthRemaining - 1));
                }
                else
                {
                    ParallelQuickSortMethod(array, from, pivot, 0);
                    ParallelQuickSortMethod(array, pivot + 1, to, 0);
                }
            }
        }

    }
}
