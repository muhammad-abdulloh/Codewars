using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    public  class Probems : Probems2, Probems3, Probems4, Probems5
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

    public class Probems2 : Probems3
    {
        public int[] DivisibleBy1(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public interface Probems3
    {
        public static int[] DivisibleBy2(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public interface Probems4
    {
        public static int[] DivisibleBy3(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }

    public interface Probems5
    {
        public static int[] DivisibleBy4(int[] numbers, int divisor)
        {
            var result = new int[1];

            for (int x = 0; x < numbers.Length; x++)
            {
                if (numbers[x] % divisor == 0) result[x] = numbers[x];
            }
            return result;
        }
    }
}
