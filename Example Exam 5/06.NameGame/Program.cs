namespace _06.NameGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string winnerName = string.Empty;
            int winnerPoints = 0;

            while (true)
            {
                string playerName = Console.ReadLine();

                if (playerName == "Stop")
                {
                    break;
                }

                int playerPoints = 0;
                int nameLength = playerName.Length;

                for (int i = 0; i < nameLength; i++)
                {
                    int inputNumber = int.Parse(Console.ReadLine());
                    int letterNumber = (int)playerName[i];

                    if (inputNumber == letterNumber)
                    {
                        playerPoints += 10;
                    }
                    else
                    {
                        playerPoints += 2;
                    }
                }

                if (playerPoints >= winnerPoints)
                {
                    winnerName = playerName;
                    winnerPoints = playerPoints;
                }
            }

            Console.WriteLine($"The winner is {winnerName} with {winnerPoints} points!");
        }
    }
}
