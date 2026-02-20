namespace _05.SpecialNumbers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int start = 1111;
            int stop = 9999;

            for (int number = start; number <= stop; number++)
            {
                int firstDigit = number / 1000;
                int secondDigit = number / 100 % 10;
                int thirdDigit = number / 10 % 10;
                int forthDigit = number % 10;

                if (firstDigit != 0 && inputNumber % firstDigit == 0 &&
                    secondDigit != 0 && inputNumber % secondDigit == 0 &&
                    thirdDigit != 0 && inputNumber % thirdDigit == 0 &&
                    forthDigit != 0 && inputNumber % forthDigit == 0)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
