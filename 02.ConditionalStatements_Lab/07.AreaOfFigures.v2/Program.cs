namespace _07.AreaOfFigures.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double area = 0;

            if (figure == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = Math.Pow(side, 2);
            }
            else if (figure == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if (figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * Math.Pow(radius, 2);
            }
            else if (figure == "triangle")
            {
                double triangleSide = double.Parse(Console.ReadLine());
                double triangleHeight = double.Parse(Console.ReadLine());
                area = triangleSide * triangleHeight / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
