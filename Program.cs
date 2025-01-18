using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                var list = new List<int> { 1, 2, -1, -2, 4, 6, -11, 24, 99, -200, 11 };
                int counter = 0;
                List<int> positiveNumbers = list.Where(x => x > 0).ToList();
                foreach (var item in positiveNumbers)
                {
                    Console.WriteLine(item);
                    counter++;
                }
                Console.WriteLine($"Count of positive numbers: {counter}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
