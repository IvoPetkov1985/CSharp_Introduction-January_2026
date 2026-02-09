namespace _03.Histogram.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            List<int> p1Numbers = new();
            List<int> p2Numbers = new();
            List<int> p3Numbers = new();
            List<int> p4Numbers = new();
            List<int> p5Numbers = new();

            for (int i = 0; i < numbersCount; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    p1Numbers.Add(currentNumber);
                }
                else if (currentNumber < 400)
                {
                    p2Numbers.Add(currentNumber);
                }
                else if (currentNumber < 600)
                {
                    p3Numbers.Add(currentNumber);
                }
                else if (currentNumber < 800)
                {
                    p4Numbers.Add(currentNumber);
                }
                else
                {
                    p5Numbers.Add(currentNumber);
                }
            }

            double p1Percent = p1Numbers.Count * 100.0 / numbersCount;
            double p2Percent = p2Numbers.Count * 100.0 / numbersCount;
            double p3Percent = p3Numbers.Count * 100.0 / numbersCount;
            double p4Percent = p4Numbers.Count * 100.0 / numbersCount;
            double p5Percent = p5Numbers.Count * 100.0 / numbersCount;

            Console.WriteLine($"{p1Percent:F2}%");
            Console.WriteLine($"{p2Percent:F2}%");
            Console.WriteLine($"{p3Percent:F2}%");
            Console.WriteLine($"{p4Percent:F2}%");
            Console.WriteLine($"{p5Percent:F2}%");
        }
    }
}
