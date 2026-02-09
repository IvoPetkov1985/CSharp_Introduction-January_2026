namespace _08.NumberSequence.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            int[] ints = new int[count];

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                ints[i] = currentNum;
            }

            int maxNumber = ints.Max();
            int minNumber = ints.Min();

            Console.WriteLine("Max number: " + maxNumber);
            Console.WriteLine("Min number: " + minNumber);
        }
    }
}
