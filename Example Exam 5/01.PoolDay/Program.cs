namespace _01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int visitorsCount = int.Parse(Console.ReadLine());
            double entryTax = double.Parse(Console.ReadLine());
            double sunbedTax = double.Parse(Console.ReadLine());
            double umbrellaTax = double.Parse(Console.ReadLine());

            double sunbedsNeeded = Math.Ceiling(visitorsCount * 0.75);
            double umbrellasNeeded = Math.Ceiling(visitorsCount / 2d);

            double sumEntryTaxes = visitorsCount * entryTax;
            double sumSunbeds = sunbedsNeeded * sunbedTax;
            double sumUmbrellas = umbrellasNeeded * umbrellaTax;
            double finalSum = sumEntryTaxes + sumSunbeds + sumUmbrellas;

            Console.WriteLine($"{finalSum:F2} lv.");
        }
    }
}
