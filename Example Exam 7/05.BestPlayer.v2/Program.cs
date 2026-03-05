namespace _05.BestPlayer.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> playersGoals = new();
            string playerName = Console.ReadLine();

            while (playerName != "END")
            {
                int goalsScored = int.Parse(Console.ReadLine());
                playersGoals.Add(playerName, goalsScored);

                if (goalsScored >= 10)
                {
                    break;
                }

                playerName = Console.ReadLine();
            }

            KeyValuePair<string, int> player = playersGoals.OrderByDescending(k => k.Value).First();
            Console.WriteLine($"{player.Key} is the best player!");

            if (player.Value >= 3)
            {
                Console.WriteLine($"He has scored {player.Value} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {player.Value} goals.");
            }
        }
    }
}
