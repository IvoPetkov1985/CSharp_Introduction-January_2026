namespace _09.WeatherForecast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            if (input == "sunny")
            {
                output = "It's warm outside!";
            }
            else
            {
                output = "It's cold outside!";
            }

            Console.WriteLine(output);
        }
    }
}
