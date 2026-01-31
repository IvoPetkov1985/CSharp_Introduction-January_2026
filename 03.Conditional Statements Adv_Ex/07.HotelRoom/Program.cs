namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double studioNight = 0;
            double apartmentNight = 0;

            if (month == "May" || month == "October")
            {
                studioNight = 50.00;
                apartmentNight = 65.00;
            }
            else if (month == "June" || month == "September")
            {
                studioNight = 75.20;
                apartmentNight = 68.70;
            }
            else if (month == "July" || month == "August")
            {
                studioNight = 76.00;
                apartmentNight = 77.00;
            }

            double totalApartmentPrice = apartmentNight * nights;
            double totalStudioPrice = studioNight * nights;

            if ((month == "May" || month == "October") && nights > 14)
            {
                totalStudioPrice *= 0.70;
            }
            else if ((month == "May" || month == "October") && nights > 7)
            {
                totalStudioPrice *= 0.95;
            }
            else if ((month == "June" || month == "September") && nights > 14)
            {
                totalStudioPrice *= 0.80;
            }

            if (nights > 14)
            {
                totalApartmentPrice *= 0.90;
            }

            Console.WriteLine($"Apartment: {totalApartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:F2} lv.");
        }
    }
}
