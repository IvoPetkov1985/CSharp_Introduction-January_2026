namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPricePerKilo = double.Parse(Console.ReadLine());
            double fruitsPricePerKilo = double.Parse(Console.ReadLine());
            int vegetablesKilos = int.Parse(Console.ReadLine());
            int fruitsKilos = int.Parse(Console.ReadLine());
            double euroRate = 1.94;

            double vegetablesIncome = vegetablesKilos * vegetablesPricePerKilo;
            double fruitsIncome = fruitsKilos * fruitsPricePerKilo;
            double incomeInEuros = (vegetablesIncome + fruitsIncome) / euroRate;
            Console.WriteLine($"{incomeInEuros:F2}");
        }
    }
}
