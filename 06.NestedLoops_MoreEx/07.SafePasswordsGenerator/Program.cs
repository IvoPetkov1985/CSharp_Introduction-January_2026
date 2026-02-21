namespace _07.SafePasswordsGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numA = int.Parse(Console.ReadLine());
            int numB = int.Parse(Console.ReadLine());
            int count = int.Parse(Console.ReadLine());

            char symbolAStart = '#';
            char symbolAEnd = '7';
            char symbolBStart = '@';
            char symbolBEnd = '`';

            char currentA = symbolAStart;
            char currentB = symbolBStart;
            int counter = 0;

            bool arePasswordsEnough = false;

            for (int x = 1; x <= numA; x++)
            {
                for (int y = 1; y <= numB; y++)
                {
                    counter++;

                    if (counter > count)
                    {
                        arePasswordsEnough = true;
                        break;
                    }

                    Console.Write($"{currentA}{currentB}{x}{y}{currentB}{currentA}|");

                    currentA++;
                    currentB++;

                    if (currentA > symbolAEnd)
                    {
                        currentA = symbolAStart;
                    }

                    if (currentB > symbolBEnd)
                    {
                        currentB = symbolBStart;
                    }
                }

                if (arePasswordsEnough == true)
                {
                    break;
                }
            }

            Console.WriteLine();
        }
    }
}
