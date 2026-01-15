namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesCount = int.Parse(Console.ReadLine());
            int pagesReadPerHour = int.Parse(Console.ReadLine());
            int daysCount = int.Parse(Console.ReadLine());

            int hoursPerDay = 0;

            int pagesPerDay = pagesCount / daysCount;
            hoursPerDay = pagesPerDay / pagesReadPerHour;

            Console.WriteLine(hoursPerDay);
        }
    }
}
