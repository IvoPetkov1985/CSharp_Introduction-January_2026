namespace _05.SpecialNumbers.v3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            int start = 1111;
            int end = 9999;

            for (int current = start; current <= end; current++)
            {
                string currentAsString = current.ToString();
                bool isSpecial = true;

                for (int index = 0; index < currentAsString.Length; index++)
                {
                    int digit = int.Parse(currentAsString[index].ToString());

                    if (digit == 0 || inputNumber % digit != 0)
                    {
                        isSpecial = false;
                        break;
                    }
                }

                if (isSpecial)
                {
                    Console.Write(current + " ");
                }
            }
        }
    }
}
