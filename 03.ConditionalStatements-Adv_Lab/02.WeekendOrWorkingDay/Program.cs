namespace _02.WeekendOrWorkingDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine();

            string output = string.Empty;

            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    output = "Working day";
                    break;
                case "Saturday":
                case "Sunday":
                    output = "Weekend";
                    break;
                default:
                    output = "Error";
                    break;
            }

            Console.WriteLine(output);
        }
    }
}
