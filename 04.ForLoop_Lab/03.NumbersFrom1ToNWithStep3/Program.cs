namespace _03.NumbersFrom1ToNWithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int step = 3;

            for (int i = 1; i <= number; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
