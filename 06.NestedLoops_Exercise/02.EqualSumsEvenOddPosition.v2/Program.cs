namespace _02.EqualSumsEvenOddPosition.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());

            List<int> validNumbers = new();

            for (int number = x1; number <= x2; number++)
            {
                int oddSum = 0;
                int evenSum = 0;
                int numberCopy = number;

                for (int position = 6; position >= 1; position--)
                {
                    int currentDigit = numberCopy % 10;

                    if (position % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }

                    numberCopy /= 10;
                }

                if (oddSum == evenSum)
                {
                    validNumbers.Add(number);
                }
            }

            if (validNumbers.Any())
            {
                Console.WriteLine(string.Join(" ", validNumbers));
            }
        }
    }
}
