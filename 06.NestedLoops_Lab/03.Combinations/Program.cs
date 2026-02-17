namespace _03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int x1 = 0; x1 <= inputNumber; x1++)
            {
                for (int x2 = 0; x2 <= inputNumber; x2++)
                {
                    for (int x3 = 0; x3 <= inputNumber; x3++)
                    {
                        if (x1 + x2 + x3 == inputNumber)
                        {
                            counter++;
                        }
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
