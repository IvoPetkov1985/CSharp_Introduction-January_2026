namespace _01.MatchTickets.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int groupSize = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double travelPrice = 0;

            switch (category)
            {
                case "VIP": ticketPrice = 499.99; break;
                case "Normal": ticketPrice = 249.99; break;
            }

            if (groupSize <= 4)
            {
                travelPrice = budget * 0.75;
            }
            else if (groupSize <= 9)
            {
                travelPrice = budget * 0.60;
            }
            else if (groupSize <= 24)
            {
                travelPrice = budget * 0.50;
            }
            else if (groupSize <= 49)
            {
                travelPrice = budget * 0.40;
            }
            else
            {
                travelPrice = budget * 0.25;
            }

            double moneyForTickets = budget - travelPrice;
            double ticketsForAll = groupSize * ticketPrice;
            double diff = Math.Abs(moneyForTickets - ticketsForAll);

            if (moneyForTickets >= ticketsForAll)
            {
                Console.WriteLine($"Yes! You have {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
            }
        }
    }
}
