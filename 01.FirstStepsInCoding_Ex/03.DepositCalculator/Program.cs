namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int termInMonths = int.Parse(Console.ReadLine());
            double annualInterest = double.Parse(Console.ReadLine());

            double interestPerYear = depositSum * annualInterest / 100;
            double interestPerMonth = interestPerYear / 12;
            double depositInterest = interestPerMonth * termInMonths;
            double totalSum = depositSum + depositInterest;

            Console.WriteLine(totalSum);
        }
    }
}
