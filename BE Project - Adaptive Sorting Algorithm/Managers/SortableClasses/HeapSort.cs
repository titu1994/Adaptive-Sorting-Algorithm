using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Project___Adaptive_Sorting_Algorithm.Classes
{
    class HeapSort: Sortable
    {
        public override void sort(ref int[] data)
        {
            heapsort(data, 0, data.Length);
        }

        private void heapsort(int[] array, int offset, int length)
        {
            var comparison = Comparer<int>.Default;
            // build binary heap from all items
            for (int i = 0; i < length; i++)
            {
                int index = i;
                int item = array[offset + i]; // use next item

                // and move it on top, if greater than parent
                while (index > 0 &&
                    comparison.Compare(array[offset + (index - 1) / 2], item) < 0)
                {
                    int top = (index - 1) / 2;
                    array[offset + index] = array[offset + top];
                    index = top;
                }
                array[offset + index] = item;
            }

            for (int i = length - 1; i > 0; i--)
            {
                // delete max and place it as last
                int last = array[offset + i];
                array[offset + i] = array[offset];

                int index = 0;
                // the last one positioned in the heap
                while (index * 2 + 1 < i)
                {
                    int left = index * 2 + 1, right = left + 1;

                    if (right < i && comparison.Compare(array[offset + left], array[offset + right]) < 0)
                    {
                        if (comparison.Compare(last, array[offset + right]) > 0) break;

                        array[offset + index] = array[offset + right];
                        index = right;
                    }
                    else
                    {
                        if (comparison.Compare(last, array[offset + left]) > 0) break;

                        array[offset + index] = array[offset + left];
                        index = left;
                    }
                }
                array[offset + index] = last;
            }
        }
    }
}
