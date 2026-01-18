namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degreesInCelsius = double.Parse(Console.ReadLine());

            double degreesInFahrenheit = degreesInCelsius * 9 / 5 + 32;

            Console.WriteLine($"{degreesInFahrenheit:F2}");
        }
    }
}
