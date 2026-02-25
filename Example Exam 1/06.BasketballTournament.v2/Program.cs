namespace _06.BasketballTournament.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wonGames = 0;
            int lostGames = 0;

            while (true)
            {
                string tournamentName = Console.ReadLine();

                if (tournamentName == "End of tournaments")
                {
                    break;
                }

                int tournamentGamesCount = int.Parse(Console.ReadLine());

                for (int game = 1; game <= tournamentGamesCount; game++)
                {
                    int homeScore = int.Parse(Console.ReadLine());
                    int guestScore = int.Parse(Console.ReadLine());
                    int diff = Math.Abs(homeScore - guestScore);

                    if (homeScore > guestScore)
                    {
                        Console.WriteLine($"Game {game} of tournament {tournamentName}: win with {diff} points.");
                        wonGames++;
                    }
                    else if (homeScore < guestScore)
                    {
                        Console.WriteLine($"Game {game} of tournament {tournamentName}: lost with {diff} points.");
                        lostGames++;
                    }
                }
            }

            int totalGamesCount = wonGames + lostGames;
            double wonPercentage = wonGames / (double)totalGamesCount * 100;
            double lostPercentage = lostGames / (double)totalGamesCount * 100;
            Console.WriteLine($"{wonPercentage:F2}% matches win");
            Console.WriteLine($"{lostPercentage:F2}% matches lost");
        }
    }
}
