namespace _02.LettersCombinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startLetter = char.Parse(Console.ReadLine());
            char endLetter = char.Parse(Console.ReadLine());
            char skipLetter = char.Parse(Console.ReadLine());

            List<string> combinations = new();

            for (char i = startLetter; i <= endLetter; i++)
            {
                for (char j = startLetter; j <= endLetter; j++)
                {
                    for (char k = startLetter; k <= endLetter; k++)
                    {
                        if (i != skipLetter && j != skipLetter && k != skipLetter)
                        {
                            string currentCombination = $"{i}{j}{k} ";
                            combinations.Add(currentCombination);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join("", combinations) + combinations.Count);
        }
    }
}
