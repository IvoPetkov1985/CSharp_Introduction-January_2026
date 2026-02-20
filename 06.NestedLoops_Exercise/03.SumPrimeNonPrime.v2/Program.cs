namespace _03.SumPrimeNonPrime.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int sumPrime = 0;
            int sumNonPrime = 0;

            while (command != "stop")
            {
                int number = int.Parse(command);

                if (number < 0)
                {
                    Console.WriteLine("Number is negative.");
                    command = Console.ReadLine();
                    continue;
                }

                if (IsPrime(number))
                {
                    sumPrime += number;
                }
                else
                {
                    sumNonPrime += number;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            if (number == 2)
            {
                return true;
            }

            if (number % 2 == 0)
            {
                return false;
            }

            int divisor = 3;

            while (divisor * divisor <= number)
            {
                if (number % divisor == 0)
                {
                    return false;
                }

                divisor++;
            }

            return true;
        }
    }
}
