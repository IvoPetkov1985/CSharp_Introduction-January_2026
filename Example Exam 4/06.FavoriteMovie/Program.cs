namespace _06.FavoriteMovie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bestMovie = string.Empty;
            int bestMoviePoints = 0;
            int movieCounter = 0;

            while (true)
            {
                string title = Console.ReadLine();

                if (title == "STOP")
                {
                    break;
                }

                int currentMoviePoints = 0;
                movieCounter++;

                for (int i = 0; i < title.Length; i++)
                {
                    char letter = title[i];
                    int charValue = (int)letter;

                    if (charValue >= 65 && charValue <= 90)
                    {
                        currentMoviePoints -= title.Length;
                    }
                    else if (charValue >= 97 && charValue <= 122)
                    {
                        currentMoviePoints -= title.Length * 2;
                    }

                    currentMoviePoints += charValue;
                }

                if (currentMoviePoints > bestMoviePoints)
                {
                    bestMovie = title;
                    bestMoviePoints = currentMoviePoints;
                }

                if (movieCounter == 7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
            }

            Console.WriteLine($"The best movie for you is {bestMovie} with {bestMoviePoints} ASCII sum.");
        }
    }
}
