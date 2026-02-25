namespace _04.Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int points = 301;
            string command = Console.ReadLine();

            int successfulShots = 0;
            int failedShots = 0;

            while (command != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());

                if (command == "Triple")
                {
                    currentPoints *= 3;
                }
                else if (command == "Double")
                {
                    currentPoints *= 2;
                }

                if (currentPoints <= points)
                {
                    successfulShots++;
                    points -= currentPoints;
                }
                else
                {
                    failedShots++;
                }

                if (points == 0)
                {
                    Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
                    break;
                }

                command = Console.ReadLine();
            }

            if (command == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {failedShots} unsuccessful shots.");
            }
        }
    }
}
