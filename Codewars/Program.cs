namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Probems.EachCons([1, 2, 3, 4, 5], 3);

            foreach (var item in items)
            {
                foreach (var item2 in item)
                {
                    Console.Write(item2 + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
