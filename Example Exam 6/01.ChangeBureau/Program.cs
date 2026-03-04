namespace _01.ChangeBureau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double yuans = double.Parse(Console.ReadLine());
            double commission = double.Parse(Console.ReadLine());

            double yuansInDollars = yuans * 0.15;
            double yuansInLevs = yuansInDollars * 1.76;
            double bitcoinsInLevs = bitcoins * 1168;
            double sumInLevs = yuansInLevs + bitcoinsInLevs;
            double sumInEuro = sumInLevs / 1.95;
            double commissionSum = sumInEuro * commission / 100;
            double result = sumInEuro - commissionSum;

            Console.WriteLine($"{result:F2}");
        }
    }
}
