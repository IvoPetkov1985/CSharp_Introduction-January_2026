namespace _06.TruckDriver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmPerMonth = double.Parse(Console.ReadLine());

            int monthsWork = 4;
            double pricePerKm = 0;

            if (kmPerMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.75;
                        break;
                    case "Summer":
                        pricePerKm = 0.90;
                        break;
                    case "Winter":
                        pricePerKm = 1.05;
                        break;
                }
            }
            else if (kmPerMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.95;
                        break;
                    case "Summer":
                        pricePerKm = 1.10;
                        break;
                    case "Winter":
                        pricePerKm = 1.25;
                        break;
                }
            }
            else
            {
                pricePerKm = 1.45;
            }

            double salaryForMonth = kmPerMonth * pricePerKm;
            double salaryForSeason = salaryForMonth * monthsWork;
            double salaryNetto = salaryForSeason * (1 - 0.10);
            Console.WriteLine($"{salaryNetto:F2}");
        }
    }
}
