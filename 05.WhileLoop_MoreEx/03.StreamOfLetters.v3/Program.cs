using System.Text.RegularExpressions;

namespace _03.StreamOfLetters.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string letterPattern = @"[A-Za-z]";
            string specialPattern = @"[con]";

            List<string> words = new();
            string currentWord = string.Empty;
            string specialWord = string.Empty;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                if (!Regex.IsMatch(command, letterPattern))
                {
                    continue;
                }

                if (Regex.IsMatch(command, specialPattern) && !specialWord.Contains(command))
                {
                    specialWord += command;
                }
                else
                {
                    currentWord += command;
                }

                if (specialWord.Length == 3)
                {
                    words.Add(currentWord);
                    currentWord = string.Empty;
                    specialWord = string.Empty;
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
