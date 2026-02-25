namespace _04.GameNumberWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstPlayerName = Console.ReadLine();
            string secondPlayerName = Console.ReadLine();

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End of game")
                {
                    Console.WriteLine($"{firstPlayerName} has {firstPlayerPoints} points");
                    Console.WriteLine($"{secondPlayerName} has {secondPlayerPoints} points");
                    break;
                }

                int firstCard = int.Parse(command);
                int secondCard = int.Parse(Console.ReadLine());

                if (firstCard > secondCard)
                {
                    firstPlayerPoints += (firstCard - secondCard);
                }
                else if (firstCard < secondCard)
                {
                    secondPlayerPoints += (secondCard - firstCard);
                }
                else
                {
                    Console.WriteLine("Number wars!");
                    int nextFirstCard = int.Parse(Console.ReadLine());
                    int nextSecondCard = int.Parse(Console.ReadLine());

                    string winner = string.Empty;
                    int playerPoints = 0;

                    if (nextFirstCard > nextSecondCard)
                    {
                        winner = firstPlayerName;
                        playerPoints = firstPlayerPoints;
                    }
                    else if (nextFirstCard < nextSecondCard)
                    {
                        winner = secondPlayerName;
                        playerPoints = secondPlayerPoints;
                    }

                    Console.WriteLine($"{winner} is winner with {playerPoints} points");
                    break;
                }
            }
        }
    }
}
