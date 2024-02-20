using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public static class Probems
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            var result = new int[1];

            for(int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result; 
        }
    }
}
