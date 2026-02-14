namespace _03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            string secretCommand = string.Empty;
            string currentWord = string.Empty;
            string fullText = string.Empty;

            while (command != "End")
            {
                char symbol = char.Parse(command);
                
                if (symbol >= 'A' && symbol <= 'Z' || symbol >= 'a' && symbol <= 'z')
                {
                    if ((symbol == 'c' || symbol == 'o' || symbol == 'n') && !secretCommand.Contains(symbol))
                    {
                        secretCommand += symbol;
                    }
                    else
                    {
                        currentWord += symbol;
                    }

                    if (secretCommand.Contains('c') && secretCommand.Contains('o') && secretCommand.Contains('n'))
                    {
                        fullText += currentWord + " ";
                        currentWord = string.Empty;
                        secretCommand = string.Empty;
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(fullText);
        }
    }
}
