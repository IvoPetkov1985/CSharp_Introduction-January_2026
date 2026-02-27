namespace _01.EasterBakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());
            double flourInKg = double.Parse(Console.ReadLine());
            double sugarInKg = double.Parse(Console.ReadLine());
            int eggsStacks = int.Parse(Console.ReadLine());
            int yeastPackages = int.Parse(Console.ReadLine());

            double sugarPricePerKg = flourPrice - flourPrice * 0.25;
            double eggStackPrice = flourPrice + flourPrice * 0.10;
            double yeastPackagePrice = sugarPricePerKg - sugarPricePerKg * 0.80;

            double sumFlour = flourPrice * flourInKg;
            double sumSugar = sugarPricePerKg * sugarInKg;
            double sumEggs = eggStackPrice * eggsStacks;
            double sumYeast = yeastPackagePrice * yeastPackages;
            double finalSum = sumFlour + sumSugar + sumEggs + sumYeast;

            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
