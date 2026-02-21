namespace _09.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isCombinationFound = false;

            for (int x1 = intervalStart; x1 <= intervalEnd; x1++)
            {
                for (int x2 = intervalStart; x2 <= intervalEnd; x2++)
                {
                    counter++;

                    if ((x1 + x2) == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter} ({x1} + {x2} = {magicNumber})");
                        isCombinationFound = true;
                        break;
                    }
                }

                if (isCombinationFound == true)
                {
                    break;
                }
            }

            if (isCombinationFound == false)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
