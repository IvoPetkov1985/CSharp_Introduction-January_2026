namespace _03.Harvest.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int winePercent = 40;
            double grapeForLiterWine = 2.5;

            int totalSqM = int.Parse(Console.ReadLine());
            double grapePerSqM = double.Parse(Console.ReadLine());
            int litersNeeded = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double totalGrape = totalSqM * grapePerSqM;
            double grapeForWine = totalGrape * winePercent / 100;
            double litersWine = grapeForWine / grapeForLiterWine;

            if (litersWine < litersNeeded)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(litersNeeded - litersWine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(litersWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(litersWine - litersNeeded)} liters left -> {Math.Ceiling((litersWine - litersNeeded) / workersCount)} liters per person.");
            }
        }
    }
}
