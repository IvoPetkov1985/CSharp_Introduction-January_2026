namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieTitle = Console.ReadLine();
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (movieTitle != "Finish")
            {
                int cinemaPlaces = int.Parse(Console.ReadLine());
                int ticketsCounter = 0;
                string ticketType = Console.ReadLine();

                while (ticketType != "End")
                {
                    ticketsCounter++;

                    if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }

                    if (ticketsCounter == cinemaPlaces)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                double percentFull = ticketsCounter * 100d / cinemaPlaces;
                Console.WriteLine($"{movieTitle} - {percentFull:F2}% full.");

                movieTitle = Console.ReadLine();
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;
            double studentPercent = studentTickets * 100d / totalTickets;
            double standardPercent = standardTickets * 100d / totalTickets;
            double kidsPercent = kidTickets * 100d / totalTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercent:F2}% student tickets.");
            Console.WriteLine($"{standardPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidsPercent:F2}% kids tickets.");
        }
    }
}
