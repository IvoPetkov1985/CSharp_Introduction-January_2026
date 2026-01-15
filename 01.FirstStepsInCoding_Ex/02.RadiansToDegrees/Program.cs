namespace _02.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputRadians = double.Parse(Console.ReadLine());
            double angelInDegrees = inputRadians * 180 / Math.PI;
            Console.WriteLine(angelInDegrees);
        }
    }
}
