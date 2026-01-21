namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double lengthOfSideOrRadius = double.Parse(Console.ReadLine());
            double result = 0;

            switch (figureType)
            {
                case "square":
                    result = Math.Pow(lengthOfSideOrRadius, 2);
                    break;
                case "rectangle":
                    double secondSide = double.Parse(Console.ReadLine());
                    result = lengthOfSideOrRadius * secondSide;
                    break;
                case "circle":
                    result = Math.PI * Math.Pow(lengthOfSideOrRadius, 2);
                    break;
                case "triangle":
                    double height = double.Parse(Console.ReadLine());
                    result = lengthOfSideOrRadius * height / 2;
                    break;
            }

            Console.WriteLine("{0:F3}", result);
        }
    }
}
