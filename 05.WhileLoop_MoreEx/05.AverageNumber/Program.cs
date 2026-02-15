namespace _05.AverageNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int[] numbers = new int[numbersCount];

            for (int i = 0; i < numbersCount; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }

            double averageValue = numbers.Average();
            Console.WriteLine($"{averageValue:F2}");
        }
    }
}
