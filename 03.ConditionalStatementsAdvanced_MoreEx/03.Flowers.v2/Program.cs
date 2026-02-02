namespace _03.Flowers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chrysantemums = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holidayMarker = Console.ReadLine();

            double chrysantemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;

            int arrangementPrice = 2;

            if (season == "Spring" || season == "Summer")
            {
                chrysantemumPrice = 2.00;
                rosePrice = 4.10;
                tulipPrice = 2.50;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                chrysantemumPrice = 3.75;
                rosePrice = 4.50;
                tulipPrice = 4.15;
            }

            double totalSum = chrysantemums * chrysantemumPrice +
                roses * rosePrice +
                tulips * tulipPrice;

            if (holidayMarker == "Y")
            {
                totalSum *= 1.15;
            }

            if (tulips > 7 && season == "Spring")
            {
                totalSum *= 0.95;
            }

            if (roses >= 10 && season == "Winter")
            {
                totalSum *= 0.90;
            }

            int flowersCount = chrysantemums + roses + tulips;

            if (flowersCount > 20)
            {
                totalSum *= 0.80;
            }

            totalSum += arrangementPrice;
            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
