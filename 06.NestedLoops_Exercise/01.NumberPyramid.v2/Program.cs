namespace _01.NumberPyramid.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            bool isBigger = false;
            int currentNumber = 1;

            for (int rows = 1; rows <= inputNumber; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write($"{currentNumber} ");
                    currentNumber++;

                    if (currentNumber > inputNumber)
                    {
                        isBigger = true;
                        break;
                    }
                }

                Console.WriteLine();

                if (isBigger)
                {
                    break;
                }
            }
        }
    }
}
