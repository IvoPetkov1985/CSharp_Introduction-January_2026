namespace _04.InchesToCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputCm = double.Parse(Console.ReadLine());
            double multiplyer = 2.54;
            double resultInInches = inputCm * multiplyer;
            Console.WriteLine(resultInInches);
        }
    }
}
