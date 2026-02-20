namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int standardTickets = 0;
            int studentTickets = 0;
            int kidTickets = 0;
            int totalTicketsCount = 0;

            while (true)
            {
                string movieName = Console.ReadLine();

                if (movieName == "Finish")
                {
                    break;
                }

                int capacity = int.Parse(Console.ReadLine());
                int soldTickets = 0;

                while (true)
                {
                    string ticketType = Console.ReadLine();

                    if (ticketType == "End")
                    {
                        break;
                    }

                    soldTickets++;

                    switch (ticketType)
                    {
                        case "student": studentTickets++; break;
                        case "standard": standardTickets++; break;
                        case "kid": kidTickets++; break;
                    }

                    if (soldTickets == capacity)
                    {
                        break;
                    }
                }

                totalTicketsCount += soldTickets;
                double percentFull = soldTickets * 100.0 / capacity;
                Console.WriteLine($"{movieName} - {percentFull:F2}% full.");
            }

            double studentPercent = studentTickets * 100.0 / totalTicketsCount;
            double standardPercent = standardTickets * 100.0 / totalTicketsCount;
            double kidsPercent = kidTickets * 100.0 / totalTicketsCount;

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentPercent:F2}% student tickets.");
            Console.WriteLine($"{standardPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidsPercent:F2}% kids tickets.");
        }
    }
}
