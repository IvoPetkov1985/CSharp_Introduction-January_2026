namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double timeInSecondsPerM = double.Parse(Console.ReadLine());

            double swimmingTime = timeInSecondsPerM * distanceInMeters;
            int delaysCount = (int)Math.Floor(distanceInMeters / 15);
            double totalDelay = delaysCount * 12.5;
            swimmingTime += totalDelay;
            double timeDiff = Math.Abs(swimmingTime - recordInSeconds);

            if (swimmingTime < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {swimmingTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {timeDiff:F2} seconds slower.");
            }
        }
    }
}
