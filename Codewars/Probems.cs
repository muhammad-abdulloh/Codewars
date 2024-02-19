using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class Probems
    {
        public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
        {
            var result = new List<List<int>>();
            for (int i = 0; i<= list.Count() - n; i++)
            {
                var sublist = new List<int>();  

                for (int j = i; j < i + n; j++)
                {
                    sublist.Add(list[j]);
                }
                result.Add(sublist);
            }

            return result;
        }
    }
}
