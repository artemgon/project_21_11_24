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
                List<string> content = [];
                Rucksack rucksack = new Rucksack("Black", "Nike", "Polyester", 0.5f, 20, content);
                rucksack.AddContent("Tent", 5);
                Console.WriteLine();
                rucksack.AddContent("Sleeping bag", 3);
                Console.WriteLine();
                rucksack.AddContent("Food", 2);
                Console.WriteLine();
                rucksack.AddContent("Water", 2);
                Console.WriteLine();
                rucksack.AddContent("Clothes", 3);
                Console.WriteLine();
                rucksack.AddContent("First aid kit", 1);
                Console.WriteLine();
                rucksack.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
