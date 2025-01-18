using project_21_11_24.Classes;

namespace project_21_11_24
{
    internal class Program
    {
        delegate void FindOdd(int[] arr);
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                FindOdd findOdd = delegate (int[] arr)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            Console.Write("Odd number: ");
                            Console.WriteLine();
                            Console.WriteLine(arr[i]);
                        }
                    }
                };
                int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                findOdd(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
