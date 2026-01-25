namespace _06.FlowerShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double magnoliaPrice = 3.25;
            double hyacinthPrice = 4.00;
            double rosePrice = 3.50;
            double cactusPrice = 8.00;
            int taxesPercent = 5;

            int magnolias = int.Parse(Console.ReadLine());
            int hyacinths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double finalSum = (magnolias * magnoliaPrice + hyacinths * hyacinthPrice + roses * rosePrice + cactuses * cactusPrice) * (1 - taxesPercent / 100.0);

            if (finalSum >= presentPrice)
            {
                Console.WriteLine("She is left with {0} leva.", Math.Floor(finalSum - presentPrice));
            }
            else
            {
                Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(presentPrice - finalSum));
            }
        }
    }
}
