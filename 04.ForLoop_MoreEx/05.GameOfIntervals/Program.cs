namespace _05.GameOfIntervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());

            double result = 0;

            int from0To9 = 0;
            int from10To19 = 0;
            int from20To29 = 0;
            int from30To39 = 0;
            int from40To50 = 0;
            int invalidNums = 0;

            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0 || number > 50)
                {
                    invalidNums++;
                    result /= 2;
                }
                else if (number <= 9)
                {
                    from0To9++;
                    result += number * 0.2;
                }
                else if (number <= 19)
                {
                    from10To19++;
                    result += number * 0.3;
                }
                else if (number <= 29)
                {
                    from20To29++;
                    result += number * 0.4;
                }
                else if (number <= 39)
                {
                    from30To39++;
                    result += 50;
                }
                else
                {
                    from40To50++;
                    result += 100;
                }
            }

            double from0To9Percent = from0To9 * 100.0 / moves;
            double from10To19Percent = from10To19 * 100.0 / moves;
            double from20To29Percent = from20To29 * 100.0 / moves;
            double from30To39Percent = from30To39 * 100.0 / moves;
            double from40To50Percent = from40To50 * 100.0 / moves;
            double invalidNumsPercent = invalidNums * 100.0 / moves;

            Console.WriteLine($"{result:F2}");
            Console.WriteLine($"From 0 to 9: {from0To9Percent:F2}%");
            Console.WriteLine($"From 10 to 19: {from10To19Percent:F2}%");
            Console.WriteLine($"From 20 to 29: {from20To29Percent:F2}%");
            Console.WriteLine($"From 30 to 39: {from30To39Percent:F2}%");
            Console.WriteLine($"From 40 to 50: {from40To50Percent:F2}%");
            Console.WriteLine($"Invalid numbers: {invalidNumsPercent:F2}%");
        }
    }
}
