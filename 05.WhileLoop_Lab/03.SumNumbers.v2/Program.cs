namespace _03.SumNumbers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperBound = int.Parse(Console.ReadLine());
            int sum = 0;

            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;

                if (sum >= upperBound)
                {
                    Console.WriteLine(sum);
                    break;
                }
            }
        }
    }
}
