namespace _04.TransportPrice.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            double taxiInitialPrice = 0.70;
            double pricePerKm = 0;
            double finalSum = 0;

            if (distance >= 100)
            {
                pricePerKm = 0.06;
            }
            else if (distance >= 20)
            {
                pricePerKm = 0.09;
            }
            else if (distance < 20)
            {
                finalSum += taxiInitialPrice;

                if (partOfDay == "day")
                {
                    pricePerKm = 0.79;
                }
                else
                {
                    pricePerKm = 0.90;
                }
            }

            finalSum += pricePerKm * distance;
            Console.WriteLine($"{finalSum:F2}");
        }
    }
}
