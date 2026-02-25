namespace _02.Skeleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlMinutes = int.Parse(Console.ReadLine());
            int controlSeconds = int.Parse(Console.ReadLine());
            double lengthInM = double.Parse(Console.ReadLine());
            int secondsPer100M = int.Parse(Console.ReadLine());

            int controlInSeconds = controlMinutes * 60 + controlSeconds;
            double countDecreases = lengthInM / 120;
            double decreasedTime = countDecreases * 2.5;
            double competitionTime = lengthInM / 100 * secondsPer100M - decreasedTime;

            if (competitionTime <= controlInSeconds)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {competitionTime:F3}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {competitionTime - controlInSeconds:F3} second slower.");
            }
        }
    }
}
