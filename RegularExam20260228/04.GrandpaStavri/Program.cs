namespace _04.GrandpaStavri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            double totalLiters = 0;
            double totalDegrees = 0;

            for (int day = 0; day < days; day++)
            {
                double liters = double.Parse(Console.ReadLine());
                double degrees = double.Parse(Console.ReadLine());

                totalLiters += liters;
                totalDegrees += degrees * liters;
            }

            double averageDegrees = totalDegrees / totalLiters;

            Console.WriteLine($"Liter: {totalLiters:F2}");
            Console.WriteLine($"Degrees: {averageDegrees:F2}");

            string output = string.Empty;

            if (averageDegrees < 38)
            {
                output = "Not good, you should baking!";
            }
            else if (averageDegrees <= 42)
            {
                output = "Super!";
            }
            else
            {
                output = "Dilution with distilled water!";
            }

            Console.WriteLine(output);
        }
    }
}
