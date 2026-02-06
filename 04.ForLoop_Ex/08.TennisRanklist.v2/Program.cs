namespace _08.TennisRanklist.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int seasonPoints = 0;
            int wonTournaments = 0;

            for (int i = 0; i < tournaments; i++)
            {
                switch (Console.ReadLine())
                {
                    case "W":
                        seasonPoints += 2000;
                        wonTournaments++;
                        break;
                    case "F":
                        seasonPoints += 1200;
                        break;
                    case "SF":
                        seasonPoints += 720;
                        break;
                }
            }

            int finalPoints = startingPoints + seasonPoints;
            int averagepoints = seasonPoints / tournaments;
            double wonPercentage = (double)wonTournaments * 100 / tournaments;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagepoints}");
            Console.WriteLine($"{wonPercentage:F2}%");
        }
    }
}
