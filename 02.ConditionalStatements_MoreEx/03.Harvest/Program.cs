namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yardInSqM = int.Parse(Console.ReadLine());
            double grapesPerSqM = double.Parse(Console.ReadLine());
            int litersWineNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double grapesPerLiter = 2.5;
            int winePercentage = 40;

            double grapesYield = yardInSqM * grapesPerSqM;
            double wine = grapesYield * winePercentage / 100 / grapesPerLiter;

            double diff = Math.Abs(wine - litersWineNeeded);

            if (wine < litersWineNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(diff)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(diff)} liters left -> {Math.Ceiling(diff / workersCount)} liters per person.");
            }
        }
    }
}
