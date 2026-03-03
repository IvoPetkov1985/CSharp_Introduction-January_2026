namespace _06.TheMostPowerfulWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mostPowerfulWord = string.Empty;
            int mostPowerValue = 0;

            while (true)
            {
                string inputWord = Console.ReadLine();

                if (inputWord == "End of words")
                {
                    break;
                }

                int wordLength = inputWord.Length;
                int wordPower = 0;

                for (int i = 0; i < wordLength; i++)
                {
                    int value = (int)inputWord[i];
                    wordPower += value;
                }

                if (inputWord.StartsWith('a') || inputWord.StartsWith('e') || inputWord.StartsWith('i') ||
                    inputWord.StartsWith('o') || inputWord.StartsWith('u') || inputWord.StartsWith('y') ||
                    inputWord.StartsWith('A') || inputWord.StartsWith('E') || inputWord.StartsWith('I') ||
                    inputWord.StartsWith('O') || inputWord.StartsWith('U') || inputWord.StartsWith('Y'))
                {
                    wordPower *= wordLength;
                }
                else
                {
                    wordPower = (int)Math.Floor(wordPower / (double)wordLength);
                }

                if (wordPower > mostPowerValue)
                {
                    mostPowerValue = wordPower;
                    mostPowerfulWord = inputWord;
                }
            }

            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {mostPowerValue}");
        }
    }
}
