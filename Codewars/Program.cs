namespace Codewars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var items = Probems.MonkeyCount(6);

            foreach (var item in items)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
