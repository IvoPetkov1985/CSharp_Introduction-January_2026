namespace _02.BraceletStand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double moneySalesPerDay = double.Parse(Console.ReadLine());
            double expensesForThePeriod = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());
            int daysCount = 5;

            double totalSavedMoney = moneyPerDay * daysCount;
            double totalProfitMoney = moneySalesPerDay * daysCount;
            double allSavedMoney = totalSavedMoney + totalProfitMoney - expensesForThePeriod;

            if (allSavedMoney >= presentPrice)
            {
                Console.WriteLine($"Profit: {allSavedMoney:F2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {presentPrice - allSavedMoney:F2} BGN.");
            }
        }
    }
}
