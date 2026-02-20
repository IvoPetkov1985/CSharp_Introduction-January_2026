namespace _06.CinemaTickets.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int studentTickets = 0;
            int standardTickets = 0;
            int kidTickets = 0;

            while (movieName != "Finish")
            {
                int projectionCapacity = int.Parse(Console.ReadLine());
                int projectionTickets = 0;

                for (int i = 0; i < projectionCapacity; i++)
                {
                    string placeType = Console.ReadLine();

                    if (placeType == "student")
                    {
                        studentTickets++;
                    }
                    else if (placeType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (placeType == "kid")
                    {
                        kidTickets++;
                    }
                    else
                    {
                        break;
                    }

                    projectionTickets++;
                }

                double attendancePercent = projectionTickets * 100.0 / projectionCapacity;
                Console.WriteLine($"{movieName} - {attendancePercent:F2}% full.");

                movieName = Console.ReadLine();
            }

            int totalTickets = studentTickets + standardTickets + kidTickets;
            double studentPercent = studentTickets * 100.0 / totalTickets;
            double standardPercent = standardTickets * 100.0 / totalTickets;
            double kidPercent = kidTickets * 100.0 / totalTickets;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentPercent:F2}% student tickets.");
            Console.WriteLine($"{standardPercent:F2}% standard tickets.");
            Console.WriteLine($"{kidPercent:F2}% kids tickets.");
        }
    }
}
