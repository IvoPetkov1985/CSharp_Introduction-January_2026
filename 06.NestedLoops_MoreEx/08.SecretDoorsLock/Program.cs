namespace _08.SecretDoorsLock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumLimit = int.Parse(Console.ReadLine());
            int secondNumLimit = int.Parse(Console.ReadLine());
            int thirdNumLimit = int.Parse(Console.ReadLine());

            for (int firstNum = 2; firstNum <= firstNumLimit; firstNum += 2)
            {
                for (int secondNum = 2; secondNum <= secondNumLimit; secondNum++)
                {
                    bool isNumPrime = true;

                    for (int divisor = 2; divisor < secondNum; divisor++)
                    {
                        if (secondNum % divisor == 0)
                        {
                            isNumPrime = false;
                        }
                    }

                    if (isNumPrime)
                    {
                        for (int thirdNum = 2; thirdNum <= thirdNumLimit; thirdNum += 2)
                        {
                            Console.WriteLine($"{firstNum} {secondNum} {thirdNum}");
                        }
                    }
                }
            }
        }
    }
}
