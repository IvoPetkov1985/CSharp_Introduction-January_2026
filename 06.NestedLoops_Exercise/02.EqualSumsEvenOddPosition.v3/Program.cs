namespace _02.EqualSumsEvenOddPosition.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int currentNumber = startNumber; currentNumber <= endNumber; currentNumber++)
            {
                int evenSum = 0;
                int oddSum = 0;

                string numberAsString = currentNumber.ToString();

                for (int index = 0; index < numberAsString.Length; index++)
                {
                    int currentDigit = int.Parse(numberAsString[index].ToString());

                    if (index % 2 == 0)
                    {
                        evenSum += currentDigit;
                    }
                    else
                    {
                        oddSum += currentDigit;
                    }
                }

                if (evenSum == oddSum)
                {
                    Console.Write(currentNumber + " ");
                }
            }

            Console.WriteLine();
        }
    }
}
