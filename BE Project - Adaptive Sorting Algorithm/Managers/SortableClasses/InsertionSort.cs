using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Project___Adaptive_Sorting_Algorithm.Classes
{
    partial class InsertionSort: Sortable
    {
        public override void sort(ref int[] data)
        {
            int temp, j;
            for (int i = 0; i < data.Length; i++)
            {
                temp = data[i];
                for (j = i - 1; j >= 0 && temp < data[j]; j--)
                    data[j + 1] = data[j];

                data[j + 1] = temp;
            }
        }
    }
}
