namespace _09.YardGreening.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal sqMeters = decimal.Parse(Console.ReadLine());
            decimal pricePerSqMeter = 7.61m;
            decimal discountMultiplyer = 0.82m;
            decimal totalSum = pricePerSqMeter * sqMeters;
            decimal sumToPay = totalSum * discountMultiplyer;
            decimal savedMoney = totalSum - sumToPay;

            Console.WriteLine($"The final price is: {sumToPay:f2} lv.");
            Console.WriteLine($"The discount is: {savedMoney:f2} lv.");
        }
    }
}
