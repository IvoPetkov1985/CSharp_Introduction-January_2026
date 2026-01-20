namespace _06.Repainting.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double safetyNylonSqMPrice = 1.50;
            double paintPerLiterPrice = 14.50;
            double thinnerPerLiterPrice = 5.00;

            double addedPaintMultiplyer = 1.10;
            int addedSafetyNylonSqM = 2;
            double nylonBagsPrice = 0.40;
            double workPerHourMultiplyer = 0.30;

            int neededSafetyNylon = int.Parse(Console.ReadLine());
            int neededPaint = int.Parse(Console.ReadLine());
            int neededThinner = int.Parse(Console.ReadLine());
            int hoursWork = int.Parse(Console.ReadLine());

            double sumForMaterials = (neededSafetyNylon + addedSafetyNylonSqM) * safetyNylonSqMPrice +
                neededPaint * addedPaintMultiplyer * paintPerLiterPrice +
                neededThinner * thinnerPerLiterPrice +
                nylonBagsPrice;

            double sumForWork = sumForMaterials * workPerHourMultiplyer * hoursWork;

            Console.WriteLine(sumForMaterials + sumForWork);
        }
    }
}
