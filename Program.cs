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
                int counter1 = 0, counter2 = 0;
                list.ForEach(x => {
                    if (x < 0)
                        counter1++;
                    if (list.Count(y => y == x) == 1)
                        counter2++;
                });
                Console.WriteLine($"Quantity of negative numbers: {counter1}");
                Console.WriteLine($"Quantity of unique numbers: {counter2}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
