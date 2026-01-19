namespace _06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackerelPricePerKilo = double.Parse(Console.ReadLine());
            double spratPricePerKilo = double.Parse(Console.ReadLine());
            double bonitoInKg = double.Parse(Console.ReadLine());
            double horseMackerelInKg = double.Parse(Console.ReadLine());
            int musselsInKg = int.Parse(Console.ReadLine());

            double bonitoPricePerKilo = mackerelPricePerKilo * 1.60;
            double horseMackarelPerKilo = spratPricePerKilo * 1.80;
            double musselsPricePerKilo = 7.50;

            double bonitoCost = bonitoInKg * bonitoPricePerKilo;
            double horseMackarelCost = horseMackerelInKg * horseMackarelPerKilo;
            double musselsCost = musselsInKg * musselsPricePerKilo;
            double totalCost = bonitoCost + horseMackarelCost + musselsCost;

            Console.WriteLine($"{totalCost:F2}");
        }
    }
}
