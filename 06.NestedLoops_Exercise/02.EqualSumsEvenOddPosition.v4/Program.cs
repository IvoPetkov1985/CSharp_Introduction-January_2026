namespace _02.EqualSumsEvenOddPosition.v4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            List<int> validNumbers = new();

            for (int currentNumber = firstNumber; currentNumber <= secondNumber; currentNumber++)
            {
                int firstDigit = currentNumber / 100000;
                int secondDigit = currentNumber / 10000 % 10;
                int thirdDigit = currentNumber / 1000 % 10;
                int forthDigit = currentNumber / 100 % 10;
                int fifthDigit = currentNumber / 10 % 10;
                int sixthDigit = currentNumber % 10;

                if (firstDigit + thirdDigit + fifthDigit == secondDigit + forthDigit + sixthDigit)
                {
                    validNumbers.Add(currentNumber);
                }
            }

            if (validNumbers.Any())
            {
                Console.WriteLine(string.Join(" ", validNumbers));
            }
        }
    }
}
