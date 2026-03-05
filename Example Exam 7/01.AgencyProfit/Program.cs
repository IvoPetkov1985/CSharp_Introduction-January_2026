namespace _01.AgencyProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double adultNettoPrice = double.Parse(Console.ReadLine());
            double servicePrice = double.Parse(Console.ReadLine());

            double kidNettoPrice = adultNettoPrice * 0.3;
            double adultTotalPrice = adultNettoPrice + servicePrice;
            double kidTotalPrice = kidNettoPrice + servicePrice;
            double totalCompanySum = adultTotalPrice * adultTickets + kidTotalPrice * kidTickets;
            double profit = totalCompanySum * 0.2;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:F2} lv.");
        }
    }
}
