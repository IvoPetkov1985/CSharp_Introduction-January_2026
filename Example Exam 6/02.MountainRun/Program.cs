namespace _02.MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSPerMeter = double.Parse(Console.ReadLine());

            double timeNeeded = distanceInMeters * timeInSPerMeter;
            double delays = Math.Floor(distanceInMeters / 50);
            double timeFromDelays = delays * 30;
            double totalTime = timeNeeded + timeFromDelays;

            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($"Yes! The new record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recordInSeconds:F2} seconds slower.");
            }
        }
    }
}
