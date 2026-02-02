namespace _02.BikeRace.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string routeType = Console.ReadLine();

            double juniorFee = 0;
            double seniorFee = 0;

            if (routeType == "trail")
            {
                juniorFee = 5.50;
                seniorFee = 7.00;
            }
            else if (routeType == "cross-country")
            {
                juniorFee = 8.00;
                seniorFee = 9.50;
            }
            else if (routeType == "downhill")
            {
                juniorFee = 12.25;
                seniorFee = 13.75;
            }
            else if (routeType == "road")
            {
                juniorFee = 20.00;
                seniorFee = 21.50;
            }

            double sumForCharity = juniors * juniorFee + seniors * seniorFee;

            if (routeType == "cross-country" && juniors + seniors >= 50)
            {
                sumForCharity *= 0.75;
            }

            sumForCharity *= 0.95;
            Console.WriteLine($"{sumForCharity:F2}");
        }
    }
}
