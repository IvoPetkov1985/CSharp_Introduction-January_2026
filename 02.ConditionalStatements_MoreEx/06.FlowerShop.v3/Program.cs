namespace _06.FlowerShop.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> prices = new()
            {
                { "magnolia", 3.25 },
                { "hyacinth", 4.00 },
                { "rose", 3.50 },
                { "cactus", 8.00 }
            };

            int taxesPercent = 5;

            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalSum = prices["magnolia"] * magnoliasCount +
                prices["hyacinth"] * hyacinthsCount +
                prices["rose"] * rosesCount +
                prices["cactus"] * cactusesCount;

            totalSum *= 1 - taxesPercent / 100.0;

            if (totalSum >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalSum - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalSum)} leva.");
            }
        }
    }
}
