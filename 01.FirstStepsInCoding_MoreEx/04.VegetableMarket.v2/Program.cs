namespace _04.VegetableMarket.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetablesPrice = double.Parse(Console.ReadLine());
            double fruitsPrice = double.Parse(Console.ReadLine());
            int vegetablesInKg = int.Parse(Console.ReadLine());
            int fruitsInKg = int.Parse(Console.ReadLine());

            double euroRate = 1.94;

            double income = (vegetablesPrice * vegetablesInKg + fruitsPrice * fruitsInKg) / euroRate;

            Console.WriteLine($"{income:F2}");
        }
    }
}
