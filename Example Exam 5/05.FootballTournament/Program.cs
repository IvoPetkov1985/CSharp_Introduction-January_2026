using System.Text;

namespace _05.FootballTournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string footballClub = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());

            int won = 0;
            int drawn = 0;
            int lost = 0;

            for (int match = 0; match < matches; match++)
            {
                char result = char.Parse(Console.ReadLine());

                switch (result)
                {
                    case 'W': won++; break;
                    case 'D': drawn++; break;
                    case 'L': lost++; break;
                }
            }

            if (matches == 0)
            {
                Console.WriteLine($"{footballClub} hasn't played any games during this season.");
            }
            else
            {
                int totalPoints = won * 3 + drawn * 1;
                double winRate = won * 100d / matches;

                StringBuilder builder = new();
                builder.AppendLine($"{footballClub} has won {totalPoints} points during this season.");
                builder.AppendLine("Total stats:");
                builder.AppendLine($"## W: {won}");
                builder.AppendLine($"## D: {drawn}");
                builder.AppendLine($"## L: {lost}");
                builder.AppendLine($"Win rate: {winRate:F2}%");
                Console.WriteLine(builder.ToString().TrimEnd());
            }
        }
    }
}
