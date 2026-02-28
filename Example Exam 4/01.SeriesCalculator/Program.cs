namespace _01.SeriesCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            int seasonsCount = int.Parse(Console.ReadLine());
            int seriesPerSeason = int.Parse(Console.ReadLine());
            double seriesDuration = double.Parse(Console.ReadLine());
            int seriesExtraDuration = 10;

            double adsDuration = seriesDuration * 0.20;
            double seriesWithAds = seriesDuration + adsDuration;
            int totalExtraDuration = seasonsCount * seriesExtraDuration;
            double totalSeriesDuration = seriesWithAds * seriesPerSeason * seasonsCount + totalExtraDuration;

            Console.WriteLine($"Total time needed to watch the {filmName} series is {totalSeriesDuration} minutes.");
        }
    }
}
