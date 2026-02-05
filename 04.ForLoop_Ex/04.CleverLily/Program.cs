namespace _04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lilyAge = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int birthdayMoney = 10;
            int moneyFromBirthdays = 0;
            int toysCount = 0;
            int brotherMoney = 0;

            for (int i = 1; i <= lilyAge; i++)
            {
                if (i % 2 == 0)
                {
                    moneyFromBirthdays += birthdayMoney;
                    birthdayMoney += 10;
                    brotherMoney++;
                }
                else
                {
                    toysCount++;
                }
            }

            int savedMoney = moneyFromBirthdays - brotherMoney;
            int moneyFromToys = toysCount * toyPrice;
            int totalMoney = savedMoney + moneyFromToys;

            if (totalMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washingMachinePrice:F2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachinePrice - totalMoney:F2}");
            }
        }
    }
}
