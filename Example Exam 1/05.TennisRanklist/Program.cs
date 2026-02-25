namespace _05.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toursCount = int.Parse(Console.ReadLine());
            int initialPoints = int.Parse(Console.ReadLine());

            int wonPoints = 0;
            int wonTours = 0;

            for (int i = 0; i < toursCount; i++)
            {
                string stage = Console.ReadLine();

                switch (stage)
                {
                    case "W": wonTours++; wonPoints += 2000; break;
                    case "F": wonPoints += 1200; break;
                    case "SF": wonPoints += 720; break;
                }
            }

            int finalPoints = initialPoints + wonPoints;
            double averagePoints = Math.Floor((double)wonPoints / toursCount);
            double wonPercent = wonTours * (double)100 / toursCount;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{wonPercent:F2}%");
        }
    }
}
