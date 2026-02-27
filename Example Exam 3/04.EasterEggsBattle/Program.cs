namespace _04.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());
            bool hasWinner = true;

            while (firstPlayerEggs > 0 && secondPlayerEggs > 0)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    hasWinner = false;
                    break;
                }

                switch (command)
                {
                    case "one": secondPlayerEggs--; break;
                    case "two": firstPlayerEggs--; break;
                }
            }

            if (hasWinner == false)
            {
                Console.WriteLine($"Player one has {firstPlayerEggs} eggs left.");
                Console.WriteLine($"Player two has {secondPlayerEggs} eggs left.");
            }
            else
            {
                if (firstPlayerEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayerEggs} eggs left.");
                }
                else if (secondPlayerEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayerEggs} eggs left.");
                }
            }
        }
    }
}
