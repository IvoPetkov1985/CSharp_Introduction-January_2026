namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double puzzlePrice = 2.60;
            double dollPrice = 3.00;
            double hugBearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2.00;
            int discountPercent = 25;
            int rentPercent = 10;

            double travelPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int hugBears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int toysCount = puzzles + dolls + hugBears + minions + trucks;
            double totalSum = puzzles * puzzlePrice + dolls * dollPrice + hugBears * hugBearPrice + minions * minionPrice + trucks * truckPrice;

            if (toysCount >= 50)
            {
                totalSum *= 1 - discountPercent / 100.0;
            }

            totalSum *= 1 - rentPercent / 100.0;

            if (totalSum >= travelPrice)
            {
                Console.WriteLine($"Yes! {totalSum - travelPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {travelPrice - totalSum:F2} lv needed.");
            }
        }
    }
}
