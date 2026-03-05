namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestPlayerName = string.Empty;
            int bestPlayersGoals = 0;

            while (true)
            {
                string playerName = Console.ReadLine();

                if (playerName == "END")
                {
                    break;
                }

                int goalsCount = int.Parse(Console.ReadLine());

                if (goalsCount > bestPlayersGoals)
                {
                    bestPlayerName = playerName;
                    bestPlayersGoals = goalsCount;
                }

                if (goalsCount >= 10)
                {
                    break;
                }
            }

            Console.WriteLine($"{bestPlayerName} is the best player!");

            if (bestPlayersGoals >= 3)
            {
                Console.WriteLine($"He has scored {bestPlayersGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {bestPlayersGoals} goals.");
            }
        }
    }
}
