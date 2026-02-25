namespace _04.Darts.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            int points = 301;

            int successfulShots = 0;
            int unsuccessfulShots = 0;

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Retire")
                {
                    break;
                }

                int shotPoints = int.Parse(Console.ReadLine());

                switch (command)
                {
                    case "Double": shotPoints *= 2; break;
                    case "Triple": shotPoints *= 3; break;
                }

                if (shotPoints <= points)
                {
                    successfulShots++;
                    points -= shotPoints;
                }
                else
                {
                    unsuccessfulShots++;
                }

                if (points == 0)
                {
                    break;
                }
            }

            if (points > 0)
            {
                Console.WriteLine($"{playerName} retired after {unsuccessfulShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} won the leg with {successfulShots} shots.");
            }
        }
    }
}
