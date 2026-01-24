namespace _04.TransportPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int travelInKm = int.Parse(Console.ReadLine());
            string dayPart = Console.ReadLine();

            double tarifPerKm = 0.0;
            double taxiInitialTax = 0.70;

            if (travelInKm >= 100)
            {
                tarifPerKm = 0.06;
            }
            else if (travelInKm >= 20)
            {
                tarifPerKm = 0.09;
            }
            else
            {
                switch (dayPart)
                {
                    case "day": tarifPerKm = 0.79; break;
                    case "night": tarifPerKm = 0.90; break;
                }
            }

            double finalSum = travelInKm * tarifPerKm;

            if (travelInKm < 20)
            {
                finalSum += taxiInitialTax;
            }

            Console.WriteLine("{0:F2}", finalSum);
        }
    }
}
