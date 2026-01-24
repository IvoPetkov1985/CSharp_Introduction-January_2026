namespace _02.SleepyTomCat.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tomPlayNorm = 30000;
            int workdayPlay = 63;
            int vacationDayPlay = 127;
            int totalDaysInYear = 365;

            int vacationDays = int.Parse(Console.ReadLine());

            int workdays = totalDaysInYear - vacationDays;
            int totalHoursPlay = vacationDays * vacationDayPlay + workdays * workdayPlay;
            int timeDiff = Math.Abs(tomPlayNorm - totalHoursPlay);
            int timeDiffInHours = timeDiff / 60;
            int timeDiffInMinutes = timeDiff % 60;

            if (totalHoursPlay > tomPlayNorm)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", timeDiffInHours, timeDiffInMinutes);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", timeDiffInHours, timeDiffInMinutes);
            }
        }
    }
}
