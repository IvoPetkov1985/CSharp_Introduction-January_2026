namespace _06.TruckDriver.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            double sumPerKm = 0;

            if (season == "Spring" || season == "Autumn")
            {
                if (kmPerMonth <= 5000)
                {
                    sumPerKm = 0.75;
                }
                else if (kmPerMonth <= 10000)
                {
                    sumPerKm = 0.95;
                }
            }
            else if (season == "Summer")
            {
                if (kmPerMonth <= 5000)
                {
                    sumPerKm = 0.90;
                }
                else if (kmPerMonth <= 10000)
                {
                    sumPerKm = 1.10;
                }
            }
            else if (season == "Winter")
            {
                if (kmPerMonth <= 5000)
                {
                    sumPerKm = 1.05;
                }
                else if (kmPerMonth <= 10000)
                {
                    sumPerKm = 1.25;
                }
            }

            if (kmPerMonth > 10000 && kmPerMonth <= 20000)
            {
                sumPerKm = 1.45;
            }

            double sumSeason = kmPerMonth * sumPerKm * 4 * 0.90;
            Console.WriteLine($"{sumSeason:F2}");
        }
    }
}
