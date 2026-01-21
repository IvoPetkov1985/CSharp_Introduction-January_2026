namespace _03.EvenOrOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            string output = string.Empty;

            if (inputNumber % 2 == 0)
            {
                output = "even";
            }
            else
            {
                output = "odd";
            }

            Console.WriteLine(output);
        }
    }
}
