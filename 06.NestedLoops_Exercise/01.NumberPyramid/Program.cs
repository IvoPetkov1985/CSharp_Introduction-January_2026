namespace _01.NumberPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int rows = 1; counter < inputNumber; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    counter++;
                    Console.Write(counter + " ");

                    if (counter == inputNumber)
                    {
                        break;
                    }

                }

                Console.WriteLine();
            }
        }
    }
}
