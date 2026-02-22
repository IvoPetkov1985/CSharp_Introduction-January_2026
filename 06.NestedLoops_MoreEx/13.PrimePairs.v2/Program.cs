namespace _13.PrimePairs.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int firstInterval = int.Parse(Console.ReadLine());
            int secondInterval = int.Parse(Console.ReadLine());

            for (int x1 = firstNumber; x1 <= firstNumber + firstInterval; x1++)
            {
                bool isX1Prime = true;

                if (x1 % 2 == 0)
                {
                    isX1Prime = false;
                }

                for (int d = 3; d * d <= x1; d++)
                {
                    if (x1 % d == 0)
                    {
                        isX1Prime = false;
                        break;
                    }
                }

                if (isX1Prime)
                {
                    for (int x2 = secondNumber; x2 <= secondNumber + secondInterval; x2++)
                    {
                        bool isX2Prime = true;

                        if (x2 % 2 == 0)
                        {
                            isX2Prime = false;
                        }

                        for (int d = 3; d * d <= x2; d++)
                        {
                            if (x2 % d == 0)
                            {
                                isX2Prime = false;
                                break;
                            }
                        }

                        if (isX2Prime)
                        {
                            Console.WriteLine($"{x1}{x2}");
                        }
                    }
                }
            }
        }
    }
}
