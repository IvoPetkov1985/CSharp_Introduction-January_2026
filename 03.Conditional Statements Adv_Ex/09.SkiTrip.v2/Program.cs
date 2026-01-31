namespace _09.SkiTrip.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string estimation = Console.ReadLine();

            double singlePrice = 0;

            if (roomType == "room for one person")
            {
                singlePrice = 18;
            }
            else if (roomType == "apartment")
            {
                singlePrice = 25;
            }
            else if (roomType == "president apartment")
            {
                singlePrice = 35;
            }

            int nights = daysCount - 1;
            double totalPrice = singlePrice * nights;

            if (roomType == "apartment")
            {
                if (daysCount > 15)
                {
                    totalPrice *= 0.5;
                }
                else if (daysCount >= 10)
                {
                    totalPrice *= 1 - 0.35;
                }
                else
                {
                    totalPrice *= 1 - 0.3;
                }
            }
            else if (roomType == "president apartment")
            {
                if (daysCount > 15)
                {
                    totalPrice *= 1 - 0.2;
                }
                else if (daysCount >= 10)
                {
                    totalPrice *= 1 - 0.15;
                }
                else
                {
                    totalPrice *= 1 - 0.1;
                }
            }

            if (estimation == "positive")
            {
                totalPrice *= 1.25;
            }
            else
            {
                totalPrice *= 1 - 0.1;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
