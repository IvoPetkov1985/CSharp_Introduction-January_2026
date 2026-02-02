namespace _10.MultiplyBy2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double inputNumber = double.Parse(Console.ReadLine());
            double product = 0;

            while (true)
            {
                if (inputNumber >= 0)
                {
                    product = inputNumber * 2;
                    Console.WriteLine($"Result: {product:F2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                    break;
                }

                inputNumber = double.Parse(Console.ReadLine());
            }
        }
    }
}
