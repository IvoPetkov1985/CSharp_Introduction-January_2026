namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;

                if (number < 2 || (number % 2 == 0 && number != 2))
                {
                    isPrime = false;
                }

                for (int d = 3; d < number; d++)
                {
                    if (number % d == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }
    }
}
