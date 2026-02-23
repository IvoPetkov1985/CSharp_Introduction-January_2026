namespace _03.MovieDestination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            double pricePerDay = 0;

            switch (season)
            {
                case "Winter":

                    if (destination == "Dubai")
                    {
                        pricePerDay = 45000;
                    }
                    else if (destination == "Sofia")
                    {
                        pricePerDay = 17000;
                    }
                    else if (destination == "London")
                    {
                        pricePerDay = 24000;
                    }

                    break;

                case "Summer":

                    if (destination == "Dubai")
                    {
                        pricePerDay = 40000;
                    }
                    else if (destination == "Sofia")
                    {
                        pricePerDay = 12500;
                    }
                    else if (destination == "London")
                    {
                        pricePerDay = 20250;
                    }

                    break;
            }

            double finalPrice = daysCount * pricePerDay;

            switch (destination)
            {
                case "Dubai":
                    finalPrice *= 0.70;
                    break;
                case "Sofia":
                    finalPrice *= 1.25;
                    break;
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
