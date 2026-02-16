namespace _03.LuckyNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            List<string> luckyNumbers = new();

            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    if (inputNumber % (i + j) == 0)
                    {
                        for (int k = 1; k <= 9; k++)
                        {
                            for (int l = 1; l <= 9; l++)
                            {
                                if ((i + j) == (k + l))
                                {
                                    string currentNumber = $"{i}{j}{k}{l}";
                                    luckyNumbers.Add(currentNumber);
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", luckyNumbers));
        }
    }
}
