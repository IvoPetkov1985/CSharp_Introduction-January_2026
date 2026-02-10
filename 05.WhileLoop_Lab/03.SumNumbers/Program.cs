namespace _03.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int limit = int.Parse(Console.ReadLine());

            int sum = 0;

            while (sum < limit)
            {
                int inputNum = int.Parse(Console.ReadLine());
                sum += inputNum;
            }

            Console.WriteLine(sum);
        }
    }
}
