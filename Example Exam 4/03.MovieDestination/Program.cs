namespace _03.MovieDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            int pricePerDay = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    pricePerDay = 45000;
                }
                else if (season == "Summer")
                {
                    pricePerDay = 40000;
                }
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    pricePerDay = 17000;
                }
                else if (season == "Summer")
                {
                    pricePerDay = 12500;
                }
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    pricePerDay = 24000;
                }
                else if (season == "Summer")
                {
                    pricePerDay = 20250;
                }
            }

            double finalPrice = pricePerDay * days;

            switch (destination)
            {
                case "Dubai": finalPrice *= 0.7; break;
                case "Sofia": finalPrice *= 1.25; break;
            }

            if (budget >= finalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {budget - finalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {finalPrice - budget:F2} leva more!");
            }
        }
    }
}
