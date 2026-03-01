namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestPlayerName = string.Empty;
            int bestPlayerScore = 0;

            while (true)
            {
                string playerName = Console.ReadLine();

                if (playerName == "END")
                {
                    break;
                }

                int goalsScored = int.Parse(Console.ReadLine());

                if (goalsScored > bestPlayerScore)
                {
                    bestPlayerName = playerName;
                    bestPlayerScore = goalsScored;
                }

                if (goalsScored >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayerName} is the best player!");
            bool hattrick = bestPlayerScore >= 3;

            if (hattrick)
            {
                Console.WriteLine($"He has scored {bestPlayerScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayerScore} goals.");
            }
        }
    }
}
