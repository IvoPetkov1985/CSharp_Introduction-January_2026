namespace _08.LunchBreak.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lunchPart = 8;
            double restPart = 4;

            string movieName = Console.ReadLine();
            int movieDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double timeForMovie = breakDuration - breakDuration / lunchPart - breakDuration / restPart;

            if (timeForMovie >= movieDuration)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(timeForMovie - movieDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(movieDuration - timeForMovie)} more minutes.");
            }
        }
    }
}
