namespace _03.StreamOfLetters.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentWord = string.Empty;
            string specialCommand = string.Empty;
            List<string> words = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                char asciiSymbol = char.Parse(command);

                if (!(asciiSymbol >= 'A' && asciiSymbol <= 'Z') && !(asciiSymbol >= 'a' && asciiSymbol <= 'z'))
                {
                    continue;
                }

                if ((asciiSymbol == 'c' || asciiSymbol == 'o' || asciiSymbol == 'n') && !specialCommand.Contains(asciiSymbol))
                {
                    specialCommand += asciiSymbol;
                }
                else
                {
                    currentWord += asciiSymbol;
                }

                if (specialCommand.Contains('c') && specialCommand.Contains('o') && specialCommand.Contains('n'))
                {
                    words.Add(currentWord);
                    currentWord = string.Empty;
                    specialCommand = string.Empty;
                }
            }

            Console.WriteLine(string.Join(" ", words));
        }
    }
}
