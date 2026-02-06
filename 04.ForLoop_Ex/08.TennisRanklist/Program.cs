namespace _08.TennisRanklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int points = int.Parse(Console.ReadLine());

            int addedPoints = 0;
            int won = 0;

            for (int i = 0; i < tournaments; i++)
            {
                string status = Console.ReadLine();

                if (status == "W")
                {
                    won++;
                    addedPoints += 2000;
                }
                else if (status == "F")
                {
                    addedPoints += 1200;
                }
                else if (status == "SF")
                {
                    addedPoints += 720;
                }
            }

            int finalPoints = points + addedPoints;
            double averagepoints = Math.Floor(addedPoints / (tournaments * 1.0));
            double wonPercent = won * 100.0 / tournaments;

            Console.WriteLine($"Final points: {finalPoints}");
            Console.WriteLine($"Average points: {averagepoints}");
            Console.WriteLine($"{wonPercent:F2}%");
        }
    }
}
