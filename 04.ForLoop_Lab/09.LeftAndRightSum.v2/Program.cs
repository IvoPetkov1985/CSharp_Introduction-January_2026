namespace _09.LeftAndRightSum.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] numbers = new int[count * 2];

            for (int i = 0; i < count * 2; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                numbers[i] = currentNum;
            }

            int leftSum = numbers
                .Skip(0)
                .Take(count)
                .Sum();
            int rightSum = numbers
                .Skip(count)
                .Take(count)
                .Sum();

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = " + diff);
            }
        }
    }
}
