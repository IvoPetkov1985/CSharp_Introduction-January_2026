namespace _05.MovieRatings.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            double[] ratings = new double[count];
            string[] movies = new string[count];

            for (int i = 0; i < count; i++)
            {
                string movie = Console.ReadLine();
                double rating = double.Parse(Console.ReadLine());
                movies[i] = movie;
                ratings[i] = rating;
            }

            double maxRating = ratings.Max();
            string maxRatedMovie = movies[Array.IndexOf(ratings, maxRating)];
            double minRating = ratings.Min();
            string minRatedMovie = movies[Array.IndexOf(ratings, minRating)];
            double averageRating = ratings.Average();

            Console.WriteLine($"{maxRatedMovie} is with highest rating: {maxRating:F1}");
            Console.WriteLine($"{minRatedMovie} is with lowest rating: {minRating:F1}");
            Console.WriteLine($"Average rating: {averageRating:F1}");
        }
    }
}
