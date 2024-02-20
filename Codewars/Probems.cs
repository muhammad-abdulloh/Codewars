using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class Probems
    {
        public static int[] MonkeyCount(int n)
        {
            int[] monkey = new int[n];

            monkey = Enumerable.Range(1, n).ToArray();

            return monkey;
        }
    }
}
