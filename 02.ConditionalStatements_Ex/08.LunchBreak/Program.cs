namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lunchDivisor = 8;
            int restDivisor = 4;

            string seriesName = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine());
            int lunchBreakDuration = int.Parse(Console.ReadLine());

            double timeForLunch = lunchBreakDuration / (lunchDivisor * 1.0);
            double timeForRest = lunchBreakDuration / (restDivisor * 1.0);
            double timeForWatching = lunchBreakDuration - timeForLunch - timeForRest;

            if (timeForWatching >= seriesDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForWatching - seriesDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesDuration - timeForWatching)} more minutes.");
            }
        }
    }
}
