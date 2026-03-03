namespace _04.Renovation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidth = int.Parse(Console.ReadLine());
            int notForPaintPercent = int.Parse(Console.ReadLine());

            int wallsArea = wallHeight * wallWidth * 4;
            double notForPaintArea = wallsArea * notForPaintPercent / 100d;
            double areaForPaint = Math.Ceiling(wallsArea - notForPaintArea);

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Tired!")
                {
                    Console.WriteLine($"{areaForPaint} quadratic m left.");
                    break;
                }

                int paint = int.Parse(input);
                areaForPaint -= paint;

                if (areaForPaint == 0)
                {
                    Console.WriteLine("All walls are painted! Great job, Pesho!");
                    break;
                }
                else if (areaForPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPaint)} l paint left!");
                    break;
                }
            }
        }
    }
}
