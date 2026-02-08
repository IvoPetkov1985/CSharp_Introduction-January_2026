namespace _08.EqualPairs.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pairs = int.Parse(Console.ReadLine());
            int[] values = new int[pairs];

            for (int i = 0; i < pairs; i++)
            {
                int firstNum = int.Parse(Console.ReadLine());
                int secondNum = int.Parse(Console.ReadLine());
                int value = firstNum + secondNum;
                values[i] = value;
            }

            if (values.All(x => x == values.First()))
            {
                Console.WriteLine($"Yes, value={values.First()}");
            }
            else
            {
                int maxDiff = 0;
                int currentNum = values.First();

                for (int i = 1; i < values.Length; i++)
                {
                    int nextNum = values[i];
                    int currentDiff = Math.Abs(nextNum - currentNum);

                    if (currentDiff > maxDiff)
                    {
                        maxDiff = currentDiff;
                    }

                    currentNum = nextNum;
                }

                Console.WriteLine($"No, maxdiff={maxDiff}");
            }
        }
    }
}
