namespace _10.MultiplyBy2.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (number >= 0)
            {
                double result = number * 2;
                Console.WriteLine($"Result: {result:F2}");
                number = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Negative number!");
        }
    }
}
