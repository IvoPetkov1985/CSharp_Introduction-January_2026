namespace _04.TransportPrice.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kilometers = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            double taxiInitialSum = 0.70;
            double taxiDay = 0.79;
            double taxiNight = 0.90;
            double bus = 0.09;
            double train = 0.06;

            double totalSum = 0;

            if (kilometers >= 100)
            {
                totalSum += kilometers * train;
            }
            else if (kilometers >= 20)
            {
                totalSum += kilometers * bus;
            }
            else if (kilometers < 20)
            {
                totalSum += taxiInitialSum;

                if (partOfDay == "day")
                {
                    totalSum += kilometers * taxiDay;
                }
                else if (partOfDay == "night")
                {
                    totalSum += kilometers * taxiNight;
                }
            }

            Console.WriteLine($"{totalSum:F2}");
        }
    }
}
