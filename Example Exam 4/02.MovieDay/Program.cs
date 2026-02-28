namespace _02.MovieDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForPhotos = int.Parse(Console.ReadLine());
            int scenesCount = int.Parse(Console.ReadLine());
            int sceneDuration = int.Parse(Console.ReadLine());
            int preparationPercent = 15;

            double preparationDuration = timeForPhotos * preparationPercent / 100d;
            int allScenesDuration = sceneDuration * scenesCount;
            double neededDuration = allScenesDuration + preparationDuration;

            if (timeForPhotos >= neededDuration)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {Math.Round(timeForPhotos - neededDuration)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {Math.Round(neededDuration - timeForPhotos)} minutes.");
            }
        }
    }
}
