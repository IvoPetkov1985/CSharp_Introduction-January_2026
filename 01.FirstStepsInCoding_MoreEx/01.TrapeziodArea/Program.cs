namespace _01.TrapeziodArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseB1 = double.Parse(Console.ReadLine());
            double baseB2 = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double trapezoidArea = (baseB1 + baseB2) * height / 2;

            Console.WriteLine($"{trapezoidArea:F2}");
        }
    }
}
