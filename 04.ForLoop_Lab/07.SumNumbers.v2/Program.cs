namespace _07.SumNumbers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count];

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
