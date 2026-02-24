namespace _02.Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelNeededInL = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double fuelPricePerL = 2.10;
            int guidePrice = 100;
            int saturdayPercent = 10;
            int sundayPercent = 20;

            double fuelSum = fuelNeededInL * fuelPricePerL;
            double safariPrice = fuelSum + guidePrice;

            if (dayOfWeek == "Saturday")
            {
                safariPrice *= 1 - saturdayPercent / 100.0;
            }
            else if (dayOfWeek == "Sunday")
            {
                safariPrice *= 1 - sundayPercent / 100.0;
            }

            if (budget >= safariPrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - safariPrice:F2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {safariPrice - budget:F2} lv.");
            }
        }
    }
}
