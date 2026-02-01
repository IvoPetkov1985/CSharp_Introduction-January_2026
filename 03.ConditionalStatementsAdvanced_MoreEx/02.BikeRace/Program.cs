namespace _02.BikeRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniorsCount = int.Parse(Console.ReadLine());
            int seniorsCount = int.Parse(Console.ReadLine());
            string traceType = Console.ReadLine();

            double juniorTicketPrice = 0;
            double seniorTicketPrice = 0;

            switch (traceType)
            {
                case "trail":
                    juniorTicketPrice = 5.50;
                    seniorTicketPrice = 7.00;
                    break;
                case "cross-country":
                    juniorTicketPrice = 8.00;
                    seniorTicketPrice = 9.50;

                    if (juniorsCount + seniorsCount >= 50)
                    {
                        juniorTicketPrice *= 0.75;
                        seniorTicketPrice *= 0.75;
                    }

                    break;
                case "downhill":
                    juniorTicketPrice = 12.25;
                    seniorTicketPrice = 13.75;
                    break;
                case "road":
                    juniorTicketPrice = 20.00;
                    seniorTicketPrice = 21.50;
                    break;
            }

            double moneyFromTickets = juniorsCount * juniorTicketPrice + seniorsCount * seniorTicketPrice;
            double moneyWithoutExpenses = moneyFromTickets * 0.95;

            Console.WriteLine($"{moneyWithoutExpenses:F2}");
        }
    }
}
