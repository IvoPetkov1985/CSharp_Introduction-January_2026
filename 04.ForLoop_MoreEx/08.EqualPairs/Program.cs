namespace _08.EqualPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairsCount = int.Parse(Console.ReadLine());

            bool areEqual = true;
            int firstPairFirstNum = int.Parse(Console.ReadLine());
            int firstPairSecondNum = int.Parse(Console.ReadLine());
            int firstValue = firstPairFirstNum + firstPairSecondNum;
            int lastValue = firstValue;
            int maxDiff = 0;

            for (int i = 1; i < pairsCount; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int value = firstNum + secondNum;

                if (value != lastValue)
                {
                    int currentDiff = Math.Abs(value - lastValue);
                    areEqual = false;
                    lastValue = value;

                    if (currentDiff > maxDiff)
                    {
                        maxDiff = currentDiff;
                    }
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"Yes, value={lastValue}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
