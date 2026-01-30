namespace _06.OperationsBetweenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double result = 0;
            string evenOrOdd = string.Empty;

            switch (operation)
            {
                case '+':
                case '-':
                case '*':

                    if (operation == '+')
                    {
                        result = n1 + n2;
                    }
                    else if (operation == '-')
                    {
                        result = n1 - n2;
                    }
                    else if (operation == '*')
                    {
                        result = n2 * n1;
                    }

                    if (result % 2 == 0)
                    {
                        evenOrOdd = "even";
                    }
                    else
                    {
                        evenOrOdd = "odd";
                    }

                    Console.WriteLine($"{n1} {operation} {n2} = {result} - {evenOrOdd}");
                    break;

                case '/':

                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = (double)n1 / n2;
                        Console.WriteLine($"{n1} {operation} {n2} = {result:F2}");
                    }

                    break;

                case '%':

                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
                    else
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} {operation} {n2} = {result}");
                    }

                    break;
            }
        }
    }
}
