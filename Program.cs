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
                Console.WriteLine("Enter some text: ");
                string text = Console.ReadLine() ?? "";
                Console.WriteLine("Enter the word you want to find: ");
                string word = Console.ReadLine() ?? "";
                Func<string, string, string> checkWord = (txt, wrd) =>
                {
                    var words = txt.Split(' ');
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (words[i] == wrd)
                        {
                            string leftWord = i > 0 ? words[i - 1] : "No left word";
                            string rightWord = i < words.Length - 1 ? words[i + 1] : "No right word";
                            return $"Yeah, the word is found. Left word: {leftWord}, Right word: {rightWord}";
                        }
                    }
                    return "No, the word is not found.";
                };
                string result = checkWord(text, word);
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
