namespace _02.HalfSumElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numsCount = int.Parse(Console.ReadLine());

            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 0; i < numsCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }

                sum += currentNumber;
            }

            int sumRestNumbers = sum - maxNumber;

            if (maxNumber == sumRestNumbers)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNumber}");
            }
            else
            {
                int diff = Math.Abs(sumRestNumbers - maxNumber);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
