namespace _06.OperationsBetweenNumbers.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            string oper = Console.ReadLine();

            double result = 0;
            bool isDivisorZero = secondNum == 0;

            if (oper == "+")
            {
                result = firstNum + secondNum;
            }
            else if (oper == "-")
            {
                result = firstNum - secondNum;
            }
            else if (oper == "*")
            {
                result = firstNum * secondNum;
            }
            else if (oper == "/")
            {
                if (isDivisorZero == false)
                {
                    result = firstNum / (secondNum * 1.0);
                }
            }
            else if (oper == "%")
            {
                if (isDivisorZero == false)
                {
                    result = firstNum % secondNum;
                }
            }

            if (oper == "+" || oper == "-" || oper == "*")
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine($"{firstNum} {oper} {secondNum} = {result} - even");
                }
                else
                {
                    Console.WriteLine($"{firstNum} {oper} {secondNum} = {result} - odd");
                }
            }
            else if (oper == "/")
            {
                if (isDivisorZero)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNum} / {secondNum} = {result:F2}");
                }
            }
            else if (oper == "%")
            {
                if (isDivisorZero)
                {
                    Console.WriteLine($"Cannot divide {firstNum} by zero");
                }
                else
                {
                    Console.WriteLine($"{firstNum} % {secondNum} = {result}");
                }
            }
        }
    }
}
