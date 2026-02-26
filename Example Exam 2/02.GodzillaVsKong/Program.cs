namespace _02.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothingPricePerExtra = double.Parse(Console.ReadLine());

            double decorPrice = budget * 0.1;
            double clothingPrice = clothingPricePerExtra * extras;

            if (extras > 150)
            {
                clothingPrice *= 0.9;
            }

            double finalSum = clothingPrice + decorPrice;

            if (budget < finalSum)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {finalSum - budget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - finalSum:F2} leva left.");
            }
        }
    }
}
