using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate int Square(int x);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Square square = delegate (int x)
                {
                    return x * x;
                };
                Console.WriteLine(square(5));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
