using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class Probems
    {
        public static int StrCount(string str, char letter)
        {
            int z = 0;

            foreach (char c in str)
            {
                if (c == letter)
                {
                    z++;
                }
            }
            return z; 
        }
    }
}
