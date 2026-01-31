namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string estimation = Console.ReadLine();

            double pricePerNight = 0;

            switch (roomType)
            {
                case "room for one person":

                    pricePerNight = 18.00;
                    break;

                case "apartment":

                    pricePerNight = 25.00;

                    if (days > 15)
                    {
                        pricePerNight *= 0.5;
                    }
                    else if (days >= 10)
                    {
                        pricePerNight *= 0.65;
                    }
                    else
                    {
                        pricePerNight *= 0.7;
                    }

                    break;

                case "president apartment":

                    pricePerNight = 35.00;

                    if (days > 15)
                    {
                        pricePerNight *= 0.8;
                    }
                    else if (days >= 10)
                    {
                        pricePerNight *= 0.85;
                    }
                    else
                    {
                        pricePerNight *= 0.9;
                    }

                    break;
            }

            int nights = days - 1;
            double priceForStay = pricePerNight * nights;

            switch (estimation)
            {
                case "positive":

                    priceForStay *= 1.25;
                    break;

                case "negative":

                    priceForStay *= 0.90;
                    break;
            }

            Console.WriteLine($"{priceForStay:F2}");
        }
    }
}
