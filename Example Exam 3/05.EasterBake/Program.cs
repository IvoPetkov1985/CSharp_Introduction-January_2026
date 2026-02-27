namespace _05.EasterBake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int easterBreadsCount = int.Parse(Console.ReadLine());

            int packageSugarGrams = 950;
            int packageFlourGrams = 750;
            int maxSugarUsed = 0;
            int maxFlourUsed = 0;
            int totalSugarUsed = 0;
            int totalFlourUsed = 0;

            for (int i = 0; i < easterBreadsCount; i++)
            {
                int sugarUsed = int.Parse(Console.ReadLine());
                int flourUsed = int.Parse(Console.ReadLine());

                totalSugarUsed += sugarUsed;
                totalFlourUsed += flourUsed;

                if (sugarUsed > maxSugarUsed)
                {
                    maxSugarUsed = sugarUsed;
                }

                if (flourUsed > maxFlourUsed)
                {
                    maxFlourUsed = flourUsed;
                }
            }

            double packagesSugarNeeded = Math.Ceiling(totalSugarUsed / (double)packageSugarGrams);
            double packagesFlourNeeded = Math.Ceiling(totalFlourUsed / (double)packageFlourGrams);

            Console.WriteLine($"Sugar: {packagesSugarNeeded}");
            Console.WriteLine($"Flour: {packagesFlourNeeded}");
            Console.WriteLine($"Max used flour is {maxFlourUsed} grams, max used sugar is {maxSugarUsed} grams.");
        }
    }
}
