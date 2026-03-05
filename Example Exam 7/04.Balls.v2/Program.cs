namespace _04.Balls.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xBallsCount = int.Parse(Console.ReadLine());

            double points = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int miscBalls = 0;
            int blackBalls = 0;

            for (int ball = 0; ball < xBallsCount; ball++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    redBalls++;
                    points += 5;
                }
                else if (color == "orange")
                {
                    orangeBalls++;
                    points += 10;
                }
                else if (color == "yellow")
                {
                    yellowBalls++;
                    points += 15;
                }
                else if (color == "white")
                {
                    whiteBalls++;
                    points += 20;
                }
                else if (color == "black")
                {
                    blackBalls++;
                    points = Math.Floor(points / 2);
                }
                else
                {
                    miscBalls++;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {miscBalls}");
            Console.WriteLine($"Divides from black balls: {blackBalls}");
        }
    }
}
