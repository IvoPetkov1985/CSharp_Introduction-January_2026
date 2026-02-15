namespace _04.NumbersDividedBy3WithoutReminder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            while (num < 100)
            {
                Console.WriteLine(num);
                num += 3;
            }
        }
    }
}
