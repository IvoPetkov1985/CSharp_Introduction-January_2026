namespace _13.PrimePairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int firstInterval = int.Parse(Console.ReadLine());
            int secondInterval = int.Parse(Console.ReadLine());

            for (int x1 = firstNum; x1 <= firstNum + firstInterval; x1++)
            {
                if (IsPrime(x1))
                {
                    for (int x2 = secondNum; x2 <= secondNum + secondInterval; x2++)
                    {
                        if (IsPrime(x2))
                        {
                            Console.WriteLine($"{x1}{x2}");
                        }
                    }
                }
            }
        }

        static bool IsPrime(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }

            for (int d = 2; d < num; d++)
            {
                if (num % d == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
