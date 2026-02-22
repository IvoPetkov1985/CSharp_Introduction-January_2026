namespace _12.TheSongOfTheWheels.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int controlValue = int.Parse(Console.ReadLine());
            int passwordPosition = 4;

            List<string> validCombinations = new();

            for (int numA = 1; numA <= 9; numA++)
            {
                for (int numB = 1; numB <= 9; numB++)
                {
                    if (numA < numB)
                    {
                        for (int numC = 1; numC <= 9; numC++)
                        {
                            for (int numD = 1; numD <= 9; numD++)
                            {
                                if (numC > numD &&
                                    (numA * numB + numC * numD) == controlValue)
                                {
                                    validCombinations.Add($"{numA}{numB}{numC}{numD}");
                                }
                            }
                        }
                    }
                }
            }

            if (validCombinations.Any())
            {
                Console.WriteLine(string.Join(" ", validCombinations));
            }

            if (validCombinations.Count >= passwordPosition)
            {
                string password = validCombinations[passwordPosition - 1];
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
