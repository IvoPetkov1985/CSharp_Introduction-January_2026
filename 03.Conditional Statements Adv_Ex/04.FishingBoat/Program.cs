namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupBudget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double boatRent = 0;

            switch (season)
            {
                case "Spring": boatRent = 3000; break;
                case "Summer":
                case "Autumn": boatRent = 4200; break;
                case "Winter": boatRent = 2600; break;
            }

            if (fishermen <= 6)
            {
                boatRent *= 0.90;
            }
            else if (fishermen <= 11)
            {
                boatRent *= 0.85;
            }
            else if (fishermen >= 12)
            {
                boatRent *= 0.75;
            }

            if (season != "Autumn" && fishermen % 2 == 0)
            {
                boatRent *= 0.95;
            }

            if (groupBudget >= boatRent)
            {
                Console.WriteLine($"Yes! You have {groupBudget - boatRent:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {boatRent - groupBudget:F2} leva.");
            }
        }
    }
}
