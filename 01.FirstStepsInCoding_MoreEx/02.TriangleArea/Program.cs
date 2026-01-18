namespace _02.TriangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sideSize = double.Parse(Console.ReadLine());
            double heightSize = double.Parse(Console.ReadLine());

            double triangleArea = sideSize * heightSize / 2;

            Console.WriteLine($"{triangleArea:F2}");
        }
    }
}
