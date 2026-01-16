namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylonPricePerSqM = 1.50;
            double paintPricePerL = 14.50;
            double thinnerPricePerL = 5.00;

            double workMultiplyer = 0.3;
            double paintMultiplyer = 1.10;
            int additionalNylonInSqM = 2;
            double bagsPrice = 0.40;

            int nylonInSqM = int.Parse(Console.ReadLine());
            int paintInL = int.Parse(Console.ReadLine());
            int thinnerInL = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            double nylonCost = (nylonInSqM + additionalNylonInSqM) * nylonPricePerSqM;
            double paintCost = paintInL * paintMultiplyer * paintPricePerL;
            double thinnerCost = thinnerInL * thinnerPricePerL;
            double materialsCost = nylonCost + paintCost + thinnerCost + bagsPrice;
            double totalCost = materialsCost + materialsCost * workMultiplyer * hoursWork;

            Console.WriteLine(totalCost);
        }
    }
}
