using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate bool CheckDay(int day);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Console.WriteLine("Enter the number of day in year: ");
                int day = int.Parse(Console.ReadLine() ?? "");
                CheckDay checkDay = delegate (int day)
                {
                    if (day == 256)
                    {
                        return true;
                    }
                    return false;
                };
                Console.WriteLine(checkDay(day));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
