namespace _03.DepositCalculator.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double initialSum = double.Parse(Console.ReadLine());
            int monthsCount = int.Parse(Console.ReadLine());
            double inputPercent = double.Parse(Console.ReadLine());

            double percent = inputPercent / 100;

            double finalSum = initialSum + monthsCount * (initialSum * percent / 12);
            Console.WriteLine(finalSum);
        }
    }
}
