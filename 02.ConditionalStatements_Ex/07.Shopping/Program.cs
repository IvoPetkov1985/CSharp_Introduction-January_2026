namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double videoCardPrice = 250.00;
            int processorPercent = 35;
            int ramStickPercent = 10;
            int discountPercent = 15;

            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int processorsCount = int.Parse(Console.ReadLine());
            int ramSticksCount = int.Parse(Console.ReadLine());

            double processorPrice = videoCardPrice * videoCardsCount * processorPercent / 100.0;
            double ramStickPrice = videoCardPrice * videoCardsCount * ramStickPercent / 100.0;

            double sum = videoCardsCount * videoCardPrice + processorsCount * processorPrice + ramSticksCount * ramStickPrice;

            if (videoCardsCount > processorsCount)
            {
                sum *= 1 - discountPercent / 100.0;
            }

            double moneyDiff = Math.Abs(budget - sum);

            if (budget >= sum)
            {
                Console.WriteLine($"You have {moneyDiff:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {moneyDiff:F2} leva more!");
            }
        }
    }
}
