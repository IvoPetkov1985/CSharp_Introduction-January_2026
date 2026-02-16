namespace _01.UniquePINCodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumLimit = int.Parse(Console.ReadLine());
            int secondNumLimit = int.Parse(Console.ReadLine());
            int thirdNumLimit = int.Parse(Console.ReadLine());

            for (int i = 2; i <= firstNumLimit; i += 2)
            {
                for (int j = 2; j <= secondNumLimit; j++)
                {
                    bool isPrime = true;

                    for (int p = 2; p < j; p++)
                    {
                        if (j % p == 0)
                        {
                            isPrime = false;
                        }
                    }

                    if (isPrime == true)
                    {
                        for (int k = 2; k <= thirdNumLimit; k += 2)
                        {
                            Console.WriteLine($"{i} {j} {k}");
                        }
                    }
                }
            }
        }
    }
}
