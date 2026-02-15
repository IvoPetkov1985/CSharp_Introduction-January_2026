namespace _05.AverageNumber.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < count; i++)
            {
                sum += int.Parse(Console.ReadLine());
            }

            double averageValue = (double)sum / count;
            Console.WriteLine($"{averageValue:F2}");
        }
    }
}
