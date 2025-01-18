using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate void EvenNumber(int number);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                EvenNumber evenNumber = (number) =>
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even number.");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd number.");
                    }
                };
                evenNumber(5);
                evenNumber(6);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
