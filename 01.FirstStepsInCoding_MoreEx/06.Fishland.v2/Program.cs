namespace _06.Fishland.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double mackarelPrice = double.Parse(Console.ReadLine());
            double spratPrice = double.Parse(Console.ReadLine());
            double bonitoInKg = double.Parse(Console.ReadLine());
            double horseMackarelInKg = double.Parse(Console.ReadLine());
            int musselsInKg = int.Parse(Console.ReadLine());

            double bonitoPercentage = 0.60;
            double horseMackarelPercentage = 0.80;
            double musselsPrice = 7.50;

            double bonitoPrice = mackarelPrice + mackarelPrice * bonitoPercentage;
            double horseMackarelPrice = spratPrice + spratPrice * horseMackarelPercentage;

            double bonitoCost = bonitoInKg * bonitoPrice;
            double horseMackarelCost = horseMackarelInKg * horseMackarelPrice;
            double musselsCost = musselsInKg * musselsPrice;
            double totalCost = bonitoCost + horseMackarelCost + musselsCost;

            Console.WriteLine($"{totalCost:F2}");
        }
    }
}
