namespace _04.VacationBooksList.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalPagesInTheBook = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            int totalTimeInHours = totalPagesInTheBook / pagesReadPerHour;
            int hoursPerDay = totalTimeInHours / daysCount;

            Console.WriteLine(hoursPerDay);
        }
    }
}
