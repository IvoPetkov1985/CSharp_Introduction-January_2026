namespace _10.OddEvenSum.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<int> evenPositionNums = new();
            List<int> oddPositionNums = new();

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenPositionNums.Add(currentNum);
                }
                else
                {
                    oddPositionNums.Add(currentNum);
                }
            }

            int evenSum = evenPositionNums.Sum();
            int oddSum = oddPositionNums.Sum();

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + evenSum);
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
