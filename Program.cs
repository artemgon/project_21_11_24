using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate int Cube(int x);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Cube myNumber = delegate(int x)
                {
                    return x * x * x;
                };
                Console.WriteLine(myNumber(3));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
