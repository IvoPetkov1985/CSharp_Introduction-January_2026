namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackages = int.Parse(Console.ReadLine());
            int markerPackages = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int inputPercentDiscount = int.Parse(Console.ReadLine());

            double penPackagePrice = 5.80;
            double markerPackagePrice = 7.20;
            double cleanerPricePerLiter = 1.20;

            double pensCost = penPackagePrice * penPackages;
            double markersCost = markerPackagePrice * markerPackages;
            double cleanerCost = cleanerPricePerLiter * litersCleaner;
            double totalSum = pensCost + markersCost + cleanerCost;
            double sumToPay = totalSum - totalSum * inputPercentDiscount / 100.0;

            Console.WriteLine(sumToPay);
        }
    }
}
