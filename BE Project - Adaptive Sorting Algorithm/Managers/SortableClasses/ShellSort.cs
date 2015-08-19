using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE_Project___Adaptive_Sorting_Algorithm.Classes
{
    class ShellSort: Sortable
    {
        public override void sort(ref int[] data)
        {
            int n = data.Length;
            int[] incs = { 1, 3, 7, 21, 48, 112, 336, 861, 1968, 4592, 13776, 33936, 86961, 198768, 463792, 1391376, 3402672, 8382192, 21479367, 49095696, 114556624, 343669872, 52913488, 2085837936 };
            for (int l = incs.Length / incs[0]; l > 0;)
            {
                int m = incs[--l];
                for (int i = m; i < n; ++i)
                {
                    int j = i - m;
                    if (data[i].CompareTo(data[j]) < 0)
                    {
                        int tempItem = data[i];
                        do
                        {
                            data[j + m] = data[j];
                            j -= m;
                        } while ((j >= 0) && (tempItem.CompareTo(data[j]) < 0));
                        data[j + m] = tempItem;
                    }
                }
            }
        }
    }
}
