namespace _03.FilmPremiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string projectionTitle = Console.ReadLine();
            string package = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            int ticketPrice = 0;

            if (projectionTitle == "John Wick")
            {
                switch (package)
                {
                    case "Drink": ticketPrice = 12; break;
                    case "Popcorn": ticketPrice = 15; break;
                    case "Menu": ticketPrice = 19; break;
                }
            }
            else if (projectionTitle == "Star Wars")
            {
                switch (package)
                {
                    case "Drink": ticketPrice = 18; break;
                    case "Popcorn": ticketPrice = 25; break;
                    case "Menu": ticketPrice = 30; break;
                }
            }
            else if (projectionTitle == "Jumanji")
            {
                switch (package)
                {
                    case "Drink": ticketPrice = 9; break;
                    case "Popcorn": ticketPrice = 11; break;
                    case "Menu": ticketPrice = 14; break;
                }
            }

            double ticketsSum = ticketPrice * tickets;

            if (projectionTitle == "Star Wars" && tickets >= 4)
            {
                ticketsSum -= ticketsSum * 0.3;
            }

            if (projectionTitle == "Jumanji" && tickets == 2)
            {
                ticketsSum -= ticketsSum * 0.15;
            }

            Console.WriteLine($"Your bill is {ticketsSum:F2} leva.");
        }
    }
}
