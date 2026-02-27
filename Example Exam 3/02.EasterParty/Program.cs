namespace _02.EasterParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double couvertPrice = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double cakePrice = budget * 0.1;
            double totalCouvertsPrice = couvertPrice * guests;

            if (guests > 20)
            {
                totalCouvertsPrice *= 0.75;
            }
            else if (guests > 15)
            {
                totalCouvertsPrice *= 0.80;
            }
            else if (guests >= 10)
            {
                totalCouvertsPrice *= 0.85;
            }

            double finalSum = cakePrice + totalCouvertsPrice;

            if (budget >= finalSum)
            {
                Console.WriteLine($"It is party time! {budget - finalSum:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {finalSum - budget:F2} leva needed.");
            }
        }
    }
}
