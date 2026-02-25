namespace _06.BasketballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int matchesWon = 0;
            int matchesLost = 0;

            string tournamentName = Console.ReadLine();

            while (tournamentName != "End of tournaments")
            {
                int matchesCount = int.Parse(Console.ReadLine());

                for (int match = 1; match <= matchesCount; match++)
                {
                    int homePoints = int.Parse(Console.ReadLine());
                    int guestPoints = int.Parse(Console.ReadLine());

                    if (homePoints > guestPoints)
                    {
                        Console.WriteLine($"Game {match} of tournament {tournamentName}: win with {homePoints - guestPoints} points.");
                        matchesWon++;
                    }
                    else if (homePoints < guestPoints)
                    {
                        Console.WriteLine($"Game {match} of tournament {tournamentName}: lost with {guestPoints - homePoints} points.");
                        matchesLost++;
                    }
                }

                tournamentName = Console.ReadLine();
            }

            int totalMatches = matchesWon + matchesLost;
            double wonPercent = matchesWon * 100d / totalMatches;
            double lostPercent = matchesLost * 100d / totalMatches;

            Console.WriteLine($"{wonPercent:F2}% matches win");
            Console.WriteLine($"{lostPercent:F2}% matches lost");
        }
    }
}
