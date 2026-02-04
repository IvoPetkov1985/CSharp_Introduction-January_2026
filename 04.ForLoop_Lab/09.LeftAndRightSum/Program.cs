namespace _09.LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sumCountNumbers = int.Parse(Console.ReadLine());

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < sumCountNumbers * 2; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());

                if (i < sumCountNumbers)
                {
                    leftSum += currentNum;
                }
                else
                {
                    rightSum += currentNum;
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine($"Yes, sum = {leftSum}");
            }
            else
            {
                int diff = Math.Abs(leftSum - rightSum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }
    }
}
