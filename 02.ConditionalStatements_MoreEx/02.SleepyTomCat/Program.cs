namespace _02.SleepyTomCat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysOff = int.Parse(Console.ReadLine());

            int tomPlayNorm = 30000;
            int minutesPerWorkday = 63;
            int minutesPerHoliday = 127;
            int daysInYear = 365;

            int workDays = daysInYear - daysOff;
            int totalMinutesPlay = workDays * minutesPerWorkday + daysOff * minutesPerHoliday;
            int diffInMinutes = Math.Abs(totalMinutesPlay - tomPlayNorm);
            int hours = diffInMinutes / 60;
            int minutes = diffInMinutes % 60;

            if (totalMinutesPlay > tomPlayNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {minutes} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {minutes} minutes less for play");
            }
        }
    }
}
