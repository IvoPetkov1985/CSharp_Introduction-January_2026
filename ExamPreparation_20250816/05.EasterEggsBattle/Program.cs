namespace _05.EasterEggsBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstPlayerEggs = int.Parse(Console.ReadLine());
            int secondPlayerEggs = int.Parse(Console.ReadLine());

            int firstEggs = firstPlayerEggs;
            int secondEggs = secondPlayerEggs;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine($"Player one has {firstEggs} eggs left.");
                    Console.WriteLine($"Player two has {secondEggs} eggs left.");
                    break;
                }

                switch (command)
                {
                    case "one": secondEggs--; break;
                    case "two": firstEggs--; break;
                }

                if (firstEggs == 0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {secondEggs} eggs left.");
                    break;
                }

                if (secondEggs == 0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {firstEggs} eggs left.");
                    break;
                }
            }
        }
    }
}
