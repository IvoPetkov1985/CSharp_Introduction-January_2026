namespace _03.WorldSnookerChampionship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tournamentStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char trophyPicture = char.Parse(Console.ReadLine());

            double singleTicketPrice = 0;
            double picture = 40.00;

            if (tournamentStage == "Quarter final")
            {
                switch (ticketType)
                {
                    case "Standard": singleTicketPrice = 55.50; break;
                    case "Premium": singleTicketPrice = 105.20; break;
                    case "VIP": singleTicketPrice = 118.90; break;
                }
            }
            else if (tournamentStage == "Semi final")
            {
                switch (ticketType)
                {
                    case "Standard": singleTicketPrice = 75.88; break;
                    case "Premium": singleTicketPrice = 125.22; break;
                    case "VIP": singleTicketPrice = 300.40; break;
                }
            }
            else if (tournamentStage == "Final")
            {
                switch (ticketType)
                {
                    case "Standard": singleTicketPrice = 110.10; break;
                    case "Premium": singleTicketPrice = 160.66; break;
                    case "VIP": singleTicketPrice = 400.00; break;
                }
            }

            double sumForTickets = singleTicketPrice * ticketsCount;

            if (sumForTickets > 4000)
            {
                sumForTickets *= 0.75;
            }
            else if (sumForTickets > 2500)
            {
                sumForTickets *= 0.90;

                if (trophyPicture == 'Y')
                {
                    sumForTickets += picture * ticketsCount;
                }
            }
            else
            {
                if (trophyPicture == 'Y')
                {
                    sumForTickets += picture * ticketsCount;
                }
            }

            Console.WriteLine($"{sumForTickets:F2}");
        }
    }
}
