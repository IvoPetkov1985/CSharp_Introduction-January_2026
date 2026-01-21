namespace _05.NumberFrom100To200
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int lowLimit = 100;
            int highLimit = 200;
            string output = string.Empty;

            if (inputNumber < lowLimit)
            {
                output = "Less than 100";
            }
            else if (inputNumber <= highLimit)
            {
                output = "Between 100 and 200";
            }
            else if (inputNumber > highLimit)
            {
                output = "Greater than 200";
            }

            Console.WriteLine(output);
        }
    }
}
