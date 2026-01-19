namespace _08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double calculatedArea = Math.PI * Math.Pow(radius, 2);
            double calculatedPerimeter = 2 * Math.PI * radius;

            Console.WriteLine($"{calculatedArea:F2}");
            Console.WriteLine($"{calculatedPerimeter:F2}");
        }
    }
}
