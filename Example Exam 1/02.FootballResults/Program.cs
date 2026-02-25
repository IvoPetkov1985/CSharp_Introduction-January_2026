namespace _02.FootballResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstMatchResult = Console.ReadLine();
            string secondMatchResult = Console.ReadLine();
            string thirdMatchResult = Console.ReadLine();

            int firstMatchHome = int.Parse(firstMatchResult[0].ToString());
            int firstMatchGuest = int.Parse(firstMatchResult[2].ToString());

            int secondMatchHome = int.Parse(secondMatchResult[0].ToString());
            int secondMatchGuest = int.Parse(secondMatchResult[2].ToString());

            int thirdMatchHome = int.Parse(thirdMatchResult[0].ToString());
            int thirdMatchGuest = int.Parse(thirdMatchResult[2].ToString());

            int won = 0;
            int lost = 0;
            int drawn = 0;

            if (firstMatchHome > firstMatchGuest)
            {
                won++;
            }
            else if (firstMatchHome < firstMatchGuest)
            {
                lost++;
            }
            else
            {
                drawn++;
            }

            if (secondMatchHome > secondMatchGuest)
            {
                won++;
            }
            else if (secondMatchHome < secondMatchGuest)
            {
                lost++;
            }
            else
            {
                drawn++;
            }

            if (thirdMatchHome > thirdMatchGuest)
            {
                won++;
            }
            else if (thirdMatchHome < thirdMatchGuest)
            {
                lost++;
            }
            else
            {
                drawn++;
            }

            Console.WriteLine($"Team won {won} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
