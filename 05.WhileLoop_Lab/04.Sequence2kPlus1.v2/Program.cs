namespace _04.Sequence2kPlus1.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int k = 1;

            while (true)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;

                if (k > inputNumber)
                {
                    break;
                }
            }
        }
    }
}
