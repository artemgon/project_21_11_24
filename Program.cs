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
                Action<string> GetRGB = delegate (string color)
                {
                    color = Lowercase(color);
                    switch (color)
                    {
                        case "red":
                            Console.WriteLine("Red: 255, 0, 0");
                            break;
                        case "orange":
                            Console.WriteLine("Orange: 255, 165, 0");
                            break;
                        case "yellow":
                            Console.WriteLine("Yellow: 255, 255, 0");
                            break;
                        case "green":
                            Console.WriteLine("Green: 0, 128, 0");
                            break;
                        case "blue":
                            Console.WriteLine("Blue: 0, 0, 255");
                            break;
                        case "indigo":
                            Console.WriteLine("Indigo: 75, 0, 130");
                            break;
                        case "violet":
                            Console.WriteLine("Violet: 238, 130, 238");
                            break;
                        default:
                            Console.WriteLine("Invalid color");
                            break;
                    }
                };
                Console.WriteLine("Enter a color: ");
                string color = Console.ReadLine() ?? "";
                GetRGB(color);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static string Lowercase(string str)
        {
            return str.ToLower();
        }
    }
}
