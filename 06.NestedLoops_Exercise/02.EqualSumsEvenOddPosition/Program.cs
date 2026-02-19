namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = firstNumber; currentNumber <= secondNumber; currentNumber++)
            {
                int tempNumber = currentNumber;
                int oddSum = 0;
                int evenSum = 0;
                int position = 6;

                while (tempNumber > 0)
                {
                    int digit = tempNumber % 10;

                    if (position % 2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }

                    position--;
                    tempNumber /= 10;
                }

                if (oddSum == evenSum)
                {
                    Console.Write(currentNumber + " ");
                }
            }
        }
    }
}
