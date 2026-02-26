namespace _03.OscarsWeekInCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieTitle = Console.ReadLine();
            string hallType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());

            double projectionPrice = 0;

            if (movieTitle == "A Star Is Born")
            {
                switch (hallType)
                {
                    case "normal": projectionPrice = 7.50; break;
                    case "luxury": projectionPrice = 10.50; break;
                    case "ultra luxury": projectionPrice = 13.50; break;
                }
            }
            else if (movieTitle == "Bohemian Rhapsody")
            {
                switch (hallType)
                {
                    case "normal": projectionPrice = 7.35; break;
                    case "luxury": projectionPrice = 9.45; break;
                    case "ultra luxury": projectionPrice = 12.75; break;
                }
            }
            else if (movieTitle == "Green Book")
            {
                switch (hallType)
                {
                    case "normal": projectionPrice = 8.15; break;
                    case "luxury": projectionPrice = 10.25; break;
                    case "ultra luxury": projectionPrice = 13.25; break;
                }
            }
            else if (movieTitle == "The Favourite")
            {
                switch (hallType)
                {
                    case "normal": projectionPrice = 8.75; break;
                    case "luxury": projectionPrice = 11.55; break;
                    case "ultra luxury": projectionPrice = 13.95; break;
                }
            }

            double income = projectionPrice * ticketsCount;
            Console.WriteLine($"{movieTitle} -> {income:F2} lv.");
        }
    }
}
