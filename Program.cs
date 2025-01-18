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
                var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
                int counter = 0;
                List<int> numbersMultiplesOfSeven = numbers.Where(x => x % 7 == 0).ToList();
                foreach (var number in numbersMultiplesOfSeven)
                {
                    Console.WriteLine($"Number {++counter}: {number}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
