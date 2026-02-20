namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int start = 1111;
            int stop = 9999;

            List<int> specialNumbers = new();

            for (int currentNumber = start; currentNumber <= stop; currentNumber++)
            {
                bool isSpecial = true;
                int numberCopy = currentNumber;

                while (numberCopy > 0)
                {
                    int digit = numberCopy % 10;

                    if (digit == 0 || inputNumber % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }

                    numberCopy /= 10;
                }

                if (isSpecial == true)
                {
                    specialNumbers.Add(currentNumber);
                }
            }

            Console.WriteLine(string.Join(" ", specialNumbers));
        }
    }
}
