namespace _02.FootballResults.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstResult = Console.ReadLine();
            string secondResult = Console.ReadLine();
            string thirdResult = Console.ReadLine();

            string[] results = new string[3];
            results[0] = firstResult;
            results[1] = secondResult;
            results[2] = thirdResult;

            int won = 0;
            int lost = 0;
            int drawn = 0;

            foreach (string result in results)
            {
                int home = int.Parse(result[0].ToString());
                int guest = int.Parse(result[2].ToString());

                if (home > guest)
                {
                    won++;
                }
                else if (home < guest)
                {
                    lost++;
                }
                else
                {
                    drawn++;
                }
            }

            Console.WriteLine($"Team won {won} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
