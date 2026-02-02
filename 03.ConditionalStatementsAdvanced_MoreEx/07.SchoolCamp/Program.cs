namespace _07.SchoolCamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            string sport = string.Empty;

            switch (season)
            {
                case "Winter":

                    switch (groupType)
                    {
                        case "boys":
                            sport = "Judo";
                            pricePerNight = 9.60;
                            break;
                        case "girls":
                            sport = "Gymnastics";
                            pricePerNight = 9.60;
                            break;
                        case "mixed":
                            sport = "Ski";
                            pricePerNight = 10.00;
                            break;
                    }

                    break;

                case "Spring":

                    switch (groupType)
                    {
                        case "boys":
                            sport = "Tennis";
                            pricePerNight = 7.20;
                            break;
                        case "girls":
                            sport = "Athletics";
                            pricePerNight = 7.20;
                            break;
                        case "mixed":
                            sport = "Cycling";
                            pricePerNight = 9.50;
                            break;
                    }

                    break;

                case "Summer":

                    switch (groupType)
                    {
                        case "boys":
                            sport = "Football";
                            pricePerNight = 15.00;
                            break;
                        case "girls":
                            sport = "Volleyball";
                            pricePerNight = 15.00;
                            break;
                        case "mixed":
                            sport = "Swimming";
                            pricePerNight = 20.00;
                            break;
                    }

                    break;
            }

            double totalPrice = nights * pricePerNight * studentsCount;

            if (studentsCount >= 10 && studentsCount < 20)
            {
                totalPrice *= 0.95;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                totalPrice *= 0.85;
            }
            else if (studentsCount >= 50)
            {
                totalPrice /= 2;
            }

            Console.WriteLine($"{sport} {totalPrice:F2} lv.");
        }
    }
}
