namespace _10.InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            bool isValid = (inputNumber >= 100 && inputNumber <= 200) || inputNumber == 0;

            if (isValid == false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
