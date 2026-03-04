namespace _06.TournamentOfChristmas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());

            double totalMoney = 0;
            int winDays = 0;
            int lostDays = 0;

            for (int day = 0; day < daysCount; day++)
            {
                string sportArt = Console.ReadLine();

                int wins = 0;
                int losts = 0;
                double dayMoney = 0;

                while (sportArt != "Finish")
                {
                    string result = Console.ReadLine();

                    switch (result)
                    {
                        case "win":
                            wins++;
                            dayMoney += 20;
                            break;
                        case "lose":
                            losts++;
                            break;
                    }

                    sportArt = Console.ReadLine();
                }

                if (wins > losts)
                {
                    dayMoney += dayMoney * 0.10;
                    winDays++;
                }
                else
                {
                    lostDays++;
                }

                totalMoney += dayMoney;
            }

            if (winDays > lostDays)
            {
                totalMoney += totalMoney * 0.20;
                Console.WriteLine($"You won the tournament! Total raised money: {totalMoney:F2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {totalMoney:F2}");
            }
        }
    }
}
