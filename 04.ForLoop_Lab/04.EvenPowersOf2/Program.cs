namespace _04.EvenPowersOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int step = 2;

            for (int i = 0; i <= number; i += step)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }
        }
    }
}
