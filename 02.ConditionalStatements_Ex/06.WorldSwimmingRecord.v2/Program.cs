namespace _06.WorldSwimmingRecord.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delayInM = 15;
            double delayTime = 12.5;

            double worldRecord = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timePerM = double.Parse(Console.ReadLine());

            double timeAllDistance = distanceInM * timePerM;
            double delays = Math.Floor(distanceInM / delayInM);
            double addedTime = delays * delayTime;
            double totalTime = timeAllDistance + addedTime;

            if (totalTime < worldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - worldRecord:F2} seconds slower.");
            }
        }
    }
}
