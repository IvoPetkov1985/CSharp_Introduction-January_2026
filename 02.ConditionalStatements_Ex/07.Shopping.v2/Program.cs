namespace _07.Shopping.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double discountMultiplyer = 0.15;
            double videocardPrice = 250.00;
            double processorMultiplyer = 0.35;
            double ramStickMultiplyer = 0.10;

            double money = double.Parse(Console.ReadLine());
            int videocardsCount = int.Parse(Console.ReadLine());
            int processorsCount = int.Parse(Console.ReadLine());
            int ramSticksCount = int.Parse(Console.ReadLine());

            double videocardsPrice = videocardsCount * videocardPrice;
            double processorsPrice = videocardsPrice * processorMultiplyer * processorsCount;
            double ramSticksPrice = videocardsPrice * ramStickMultiplyer * ramSticksCount;
            double finalSum = videocardsPrice + processorsPrice + ramSticksPrice;

            if (videocardsCount > processorsCount)
            {
                finalSum *= 1 - discountMultiplyer;
            }

            if (money >= finalSum)
            {
                Console.WriteLine($"You have {money - finalSum:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalSum - money:F2} leva more!");
            }
        }
    }
}
