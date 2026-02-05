namespace _03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int firstCount = 0;
            int secondCount = 0;
            int thirdCount = 0;
            int fourthCount = 0;
            int fifthCount = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    firstCount++;
                }
                else if (currentNumber <= 399)
                {
                    secondCount++;
                }
                else if (currentNumber <= 599)
                {
                    thirdCount++;
                }
                else if (currentNumber <= 799)
                {
                    fourthCount++;
                }
                else
                {
                    fifthCount++;
                }
            }

            double p1 = firstCount * 100.0 / numbersCount;
            double p2 = secondCount * 100.0 / numbersCount;
            double p3 = thirdCount * 100.0 / numbersCount;
            double p4 = fourthCount * 100.0 / numbersCount;
            double p5 = fifthCount * 100.0 / numbersCount;

            Console.WriteLine($"{p1:F2}%");
            Console.WriteLine($"{p2:F2}%");
            Console.WriteLine($"{p3:F2}%");
            Console.WriteLine($"{p4:F2}%");
            Console.WriteLine($"{p5:F2}%");
        }
    }
}
