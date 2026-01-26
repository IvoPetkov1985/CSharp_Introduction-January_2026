namespace _05.GodzillaVsKong.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double decorMultiplyer = 0.10;
            double clothingMultiplyer = 0.10;

            double movieBudget = double.Parse(Console.ReadLine());
            int extrasCount = int.Parse(Console.ReadLine());
            double singleClothingPrice = double.Parse(Console.ReadLine());

            double decorPrice = movieBudget * decorMultiplyer;
            double clothingPrice = extrasCount * singleClothingPrice;

            if (extrasCount > 150)
            {
                clothingPrice = clothingPrice * (1 - clothingMultiplyer);
            }

            double moneyForClothingAndDecor = clothingPrice + decorPrice;

            if (moneyForClothingAndDecor > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyForClothingAndDecor - movieBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - moneyForClothingAndDecor:F2} leva left.");
            }
        }
    }
}
