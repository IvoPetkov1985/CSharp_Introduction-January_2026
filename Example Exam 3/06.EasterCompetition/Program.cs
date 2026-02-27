namespace _06.EasterCompetition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());
            int bestBakerPoints = 0;
            string bestBakerName = string.Empty;

            for (int i = 0; i < easterBreadsCount; i++)
            {
                string bakerName = Console.ReadLine();
                string command = Console.ReadLine();

                int bakerTotalPoints = 0;

                while (command != "Stop")
                {
                    int points = int.Parse(command);
                    bakerTotalPoints += points;

                    command = Console.ReadLine();
                }

                Console.WriteLine($"{bakerName} has {bakerTotalPoints} points.");

                if (bakerTotalPoints > bestBakerPoints)
                {
                    bestBakerPoints = bakerTotalPoints;
                    bestBakerName = bakerName;
                    Console.WriteLine($"{bakerName} is the new number 1!");
                }
            }

            Console.WriteLine($"{bestBakerName} won competition with {bestBakerPoints} points!");
        }
    }
}
