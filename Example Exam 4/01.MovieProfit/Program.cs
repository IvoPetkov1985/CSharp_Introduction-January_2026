namespace _01.MovieProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPercent = int.Parse(Console.ReadLine());

            double sumPerDay = ticketPrice * tickets;
            double sumAllDays = sumPerDay * days;
            double cinemaProfit = sumAllDays * cinemaPercent / 100d;
            double movieProfit = sumAllDays - cinemaProfit;

            Console.WriteLine($"The profit from the movie {movieName} is {movieProfit:F2} lv.");
        }
    }
}
