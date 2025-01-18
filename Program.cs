using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate int Max(int[] array);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Max max = delegate (int[] array)
                {
                    int max = array[0];
                    for (int i = 1; i < array.Length; i++)
                    {
                        if (array[i] > max)
                        {
                            max = array[i];
                        }
                    }
                    return max;
                };
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                Console.WriteLine(max(array));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
