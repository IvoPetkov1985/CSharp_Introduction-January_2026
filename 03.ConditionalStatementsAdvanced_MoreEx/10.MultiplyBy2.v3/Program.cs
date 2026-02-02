namespace _10.MultiplyBy2.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            while (true)
            {
                if (number < 0)
                {
                    Console.WriteLine("Negative number!");
                    break;
                }
                else
                {
                    number *= 2;
                    Console.WriteLine($"Result: {number:F2}");
                }

                number = double.Parse(Console.ReadLine());
            }
        }
    }
}
