namespace _01.MatchTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int fansCount = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double transportPrice = 0;

            if (category == "VIP")
            {
                ticketPrice = 499.99;
            }
            else if (category == "Normal")
            {
                ticketPrice = 249.99;
            }

            if (fansCount <= 4)
            {
                transportPrice = budget * 0.75;
            }
            else if (fansCount <= 9)
            {
                transportPrice = budget * 0.60;
            }
            else if (fansCount <= 24)
            {
                transportPrice = budget * 0.50;
            }
            else if (fansCount <= 49)
            {
                transportPrice = budget * 0.40;
            }
            else
            {
                transportPrice = budget * 0.25;
            }

            double moneyForTickets = budget - transportPrice;
            double priceForTickets = ticketPrice * fansCount;

            if (moneyForTickets >= priceForTickets)
            {
                Console.WriteLine($"Yes! You have {moneyForTickets - priceForTickets:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceForTickets - moneyForTickets:F2} leva.");
            }
        }
    }
}
