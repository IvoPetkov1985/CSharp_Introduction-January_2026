namespace _12.TheSongOfTheWheels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());

            int combinationsCounter = 0;
            string password = string.Empty;

            for (int valueA = 1; valueA <= 9; valueA++)
            {
                for (int valueB = 1; valueB <= 9; valueB++)
                {
                    for (int valueC = 1; valueC <= 9; valueC++)
                    {
                        for (int valueD = 1; valueD <= 9; valueD++)
                        {
                            if ((valueA * valueB + valueC * valueD) == controlValue &&
                                valueA < valueB &&
                                valueC > valueD)
                            {
                                combinationsCounter++;
                                Console.Write($"{valueA}{valueB}{valueC}{valueD} ");

                                if (combinationsCounter == 4)
                                {
                                    password = $"{valueA}{valueB}{valueC}{valueD}";
                                }
                            }
                        }
                    }
                }
            }

            if (combinationsCounter > 0)
            {
                Console.WriteLine();
            }

            if (password != string.Empty)
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
