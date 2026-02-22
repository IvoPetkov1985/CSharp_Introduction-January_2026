namespace _11.HappyCatParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double totalSum = 0;

            for (int day = 1; day <= days; day++)
            {
                double sumOfTheDay = 0;

                for (int hour = 1; hour <= hours; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        sumOfTheDay += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        sumOfTheDay += 1.25;
                    }
                    else
                    {
                        sumOfTheDay += 1.00;
                    }
                }

                totalSum += sumOfTheDay;
                Console.WriteLine($"Day: {day} - {sumOfTheDay:F2} leva");
            }

            Console.WriteLine($"Total: {totalSum:F2} leva");
        }
    }
}
