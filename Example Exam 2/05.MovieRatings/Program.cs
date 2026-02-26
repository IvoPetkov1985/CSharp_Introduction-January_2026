namespace _05.MovieRatings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int movies = int.Parse(Console.ReadLine());
            Dictionary<string, double> moviesRatings = new();

            for (int movie = 0; movie < movies; movie++)
            {
                string name = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                moviesRatings.Add(name, rating);
            }

            KeyValuePair<string, double> highestRatingMovie = moviesRatings.OrderByDescending(x => x.Value).First();
            KeyValuePair<string, double> lowestRatingMovie = moviesRatings.OrderBy(x => x.Value).First();
            double average = moviesRatings.Values.Average();

            Console.WriteLine($"{highestRatingMovie.Key} is with highest rating: {highestRatingMovie.Value:F1}");
            Console.WriteLine($"{lowestRatingMovie.Key} is with lowest rating: {lowestRatingMovie.Value:F1}");
            Console.WriteLine($"Average rating: {average:F1}");
        }
    }
}
