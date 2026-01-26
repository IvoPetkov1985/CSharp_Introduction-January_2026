namespace _08.FuelTank_Part2.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> fuelPrices = new()
            {
                { "gasoline", 2.22 },
                { "diesel", 2.33 },
                { "gas", 0.93 }
            };

            Dictionary<string, double> cardDiscounts = new()
            {
                { "gasoline", 0.18 },
                { "diesel", 0.12 },
                { "gas", 0.08 }
            };

            int firstDiscountPercent = 8;
            int secondDiscountPercent = 10;

            string fuelType = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double totalSum = 0;

            if (fuelType == "Gasoline")
            {
                totalSum = fuelPrices["gasoline"] * quantity;

                if (clubCard == "Yes")
                {
                    totalSum -= cardDiscounts["gasoline"] * quantity;
                }
            }
            else if (fuelType == "Diesel")
            {
                totalSum = fuelPrices["diesel"] * quantity;

                if (clubCard == "Yes")
                {
                    totalSum -= cardDiscounts["diesel"] * quantity;
                }
            }
            else if (fuelType == "Gas")
            {
                totalSum = fuelPrices["gas"] * quantity;

                if (clubCard == "Yes")
                {
                    totalSum -= cardDiscounts["gas"] * quantity;
                }
            }

            if (quantity >= 20 && quantity <= 25)
            {
                totalSum *= 1 - firstDiscountPercent / 100.0;
            }
            else if (quantity > 25)
            {
                totalSum *= 1 - secondDiscountPercent / 100.0;
            }

            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
