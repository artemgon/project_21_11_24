using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate int Min(int[] array);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Min min = delegate (int[] array)
                {
                    int min = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] < min)
                        {
                            min = array[i];
                        }
                    }
                    return min;
                };
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine(min(array));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
