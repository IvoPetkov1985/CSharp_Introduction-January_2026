namespace _07.SchoolCamp.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string groupType = Console.ReadLine();
            int studentsCount = int.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());

            string sport = string.Empty;
            double nightPrice = 0;

            if (groupType == "girls")
            {
                if (season == "Winter")
                {
                    nightPrice = 9.60;
                    sport = "Gymnastics";
                }
                else if (season == "Spring")
                {
                    nightPrice = 7.20;
                    sport = "Athletics";
                }
                else if (season == "Summer")
                {
                    nightPrice = 15.00;
                    sport = "Volleyball";
                }
            }
            else if (groupType == "boys")
            {
                if (season == "Winter")
                {
                    nightPrice = 9.60;
                    sport = "Judo";
                }
                else if (season == "Spring")
                {
                    nightPrice = 7.20;
                    sport = "Tennis";
                }
                else if (season == "Summer")
                {
                    nightPrice = 15.00;
                    sport = "Football";
                }
            }
            else if (groupType == "mixed")
            {
                if (season == "Winter")
                {
                    nightPrice = 10.00;
                    sport = "Ski";
                }
                else if (season == "Spring")
                {
                    nightPrice = 9.50;
                    sport = "Cycling";
                }
                else if (season == "Summer")
                {
                    nightPrice = 20.00;
                    sport = "Swimming";
                }
            }

            double finalSum = nightsCount * nightPrice * studentsCount;

            if (studentsCount >= 10 && studentsCount < 20)
            {
                finalSum *= 0.95;
            }
            else if (studentsCount >= 20 && studentsCount < 50)
            {
                finalSum *= 0.85;
            }
            else if (studentsCount >= 50)
            {
                finalSum /= 2;
            }

            Console.WriteLine($"{sport} {finalSum:F2} lv.");
        }
    }
}
