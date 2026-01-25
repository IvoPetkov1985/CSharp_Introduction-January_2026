namespace _06.FlowerShop.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4.00;
            double rosePrice = 3.50;
            double cactusPrice = 8.00;
            double taxesMultiplier = 0.95;

            int magnoliasCount = int.Parse(Console.ReadLine());
            int hyacinthsCount = int.Parse(Console.ReadLine());
            int rosesCount = int.Parse(Console.ReadLine());
            int cactusesCount = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double totalPrice = magnoliasCount * magnoliaPrice + hyacinthsCount * hyacinthPrice + rosesCount * rosePrice + cactusesCount * cactusPrice;
            totalPrice *= taxesMultiplier;

            if (totalPrice >= presentPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalPrice - presentPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(presentPrice - totalPrice)} leva.");
            }
        }
    }
}
