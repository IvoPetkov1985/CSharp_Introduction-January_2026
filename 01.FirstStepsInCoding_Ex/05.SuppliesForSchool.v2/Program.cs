namespace _05.SuppliesForSchool.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pensPackagePrice = 5.80;
            double markersPackagePrice = 7.20;
            double cleanerLiterPrice = 1.20;

            int pensPackagesCount = int.Parse(Console.ReadLine());
            int markersPackagesCount = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int percentageDiscount = int.Parse(Console.ReadLine());

            double totalSum = (pensPackagesCount * pensPackagePrice +
                markersPackagesCount * markersPackagePrice +
                litersCleaner * cleanerLiterPrice) *
                (1 - percentageDiscount / 100.0);
            Console.WriteLine(totalSum);
        }
    }
}
