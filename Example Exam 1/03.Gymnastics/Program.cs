namespace _03.Gymnastics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string apparatus = Console.ReadLine();

            double difficultyRating = 0;
            double performanceRating = 0;
            double maxTotalRating = 20;

            if (apparatus == "ribbon")
            {
                switch (country)
                {
                    case "Russia":
                        difficultyRating = 9.100;
                        performanceRating = 9.400;
                        break;
                    case "Bulgaria":
                        difficultyRating = 9.600;
                        performanceRating = 9.400;
                        break;
                    case "Italy":
                        difficultyRating = 9.200;
                        performanceRating = 9.500;
                        break;
                }
            }
            else if (apparatus == "hoop")
            {
                switch (country)
                {
                    case "Russia":
                        difficultyRating = 9.300;
                        performanceRating = 9.800;
                        break;
                    case "Bulgaria":
                        difficultyRating = 9.550;
                        performanceRating = 9.750;
                        break;
                    case "Italy":
                        difficultyRating = 9.450;
                        performanceRating = 9.350;
                        break;
                }
            }
            else if (apparatus == "rope")
            {
                switch (country)
                {
                    case "Russia":
                        difficultyRating = 9.600;
                        performanceRating = 9.000;
                        break;
                    case "Bulgaria":
                        difficultyRating = 9.500;
                        performanceRating = 9.400;
                        break;
                    case "Italy":
                        difficultyRating = 9.700;
                        performanceRating = 9.150;
                        break;
                }
            }

            double totalRating = difficultyRating + performanceRating;
            double diffPoints = maxTotalRating - totalRating;
            double diffInPercentage = diffPoints / maxTotalRating * 100;

            Console.WriteLine($"The team of {country} get {totalRating:F3} on {apparatus}.");
            Console.WriteLine($"{diffInPercentage:F2}%");
        }
    }
}
