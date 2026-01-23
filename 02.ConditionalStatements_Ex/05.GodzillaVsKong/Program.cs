namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decorPercentage = 10;
            int clothingDiscountPercentage = 10;
            int extrasCountForDiscount = 150;

            double movieBudget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double extraClothingPrice = double.Parse(Console.ReadLine());

            double decorCost = movieBudget * decorPercentage / 100.0;
            double clothingCost = extrasCount * extraClothingPrice;

            if (extrasCount > extrasCountForDiscount)
            {
                clothingCost *= (1 - clothingDiscountPercentage / 100.0);
            }

            double totalCost = decorCost + clothingCost;

            if (totalCost > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCost - movieBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - totalCost:F2} leva left.");
            }
        }
    }
}
