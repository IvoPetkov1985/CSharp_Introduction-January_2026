namespace _06.TournamentOfChristmas.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double totalMoney = 0;
            int daysWon = 0;

            for (int day = 0; day < days; day++)
            {
                int gamesWon = 0;
                int gamesLost = 0;
                double dailyMoney = 0;

                while (true)
                {
                    string game = Console.ReadLine();

                    if (game == "Finish")
                    {
                        break;
                    }

                    string result = Console.ReadLine();

                    if (result == "win")
                    {
                        dailyMoney += 20;
                        gamesWon++;
                    }
                    else if (result == "lose")
                    {
                        gamesLost++;
                    }
                }

                if (gamesWon > gamesLost)
                {
                    dailyMoney *= 1.10;
                    daysWon++;
                }

                totalMoney += dailyMoney;
            }

            if (daysWon > days / 2)
            {
                totalMoney *= 1.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");
            }
        }
    }
}
