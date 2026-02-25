namespace _01.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualFee = int.Parse(Console.ReadLine());

            double sneakers = annualFee - annualFee * 0.4;
            double jersey = sneakers - sneakers * 0.2;
            double ball = jersey / 4;
            double accessories = ball / 5;
            double sumPerYear = annualFee + sneakers + jersey + ball + accessories;

            Console.WriteLine($"{sumPerYear:F2}");
        }
    }
}
