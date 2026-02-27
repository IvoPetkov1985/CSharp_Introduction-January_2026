namespace _03.EasterTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string periodDates = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            int nightPrice = 0;

            if (periodDates == "21-23")
            {
                switch (destination)
                {
                    case "France": nightPrice = 30; break;
                    case "Italy": nightPrice = 28; break;
                    case "Germany": nightPrice = 32; break;
                }
            }
            else if (periodDates == "24-27")
            {
                switch (destination)
                {
                    case "France": nightPrice = 35; break;
                    case "Italy": nightPrice = 32; break;
                    case "Germany": nightPrice = 37; break;
                }
            }
            else if (periodDates == "28-31")
            {
                switch (destination)
                {
                    case "France": nightPrice = 40; break;
                    case "Italy": nightPrice = 39; break;
                    case "Germany": nightPrice = 43; break;
                }
            }

            int finalSum = nights * nightPrice;
            Console.WriteLine($"Easter trip to {destination} : {finalSum:F2} leva.");
        }
    }
}
