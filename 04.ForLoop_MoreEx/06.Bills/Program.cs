namespace _06.Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            int waterBill = 20;
            int internetBill = 15;

            double electricity = 0;
            double water = 0;
            double internet = 0;
            double others = 0;
            double total = 0;

            for (int i = 0; i < months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                double otherBills = (electricityBill + waterBill + internetBill) * 1.20;

                electricity += electricityBill;
                water += waterBill;
                internet += internetBill;
                others += otherBills;
                total += electricityBill + waterBill + internetBill + otherBills;
            }

            double average = total / months;

            Console.WriteLine($"Electricity: {electricity:F2} lv");
            Console.WriteLine($"Water: {water:F2} lv");
            Console.WriteLine($"Internet: {internet:F2} lv");
            Console.WriteLine($"Other: {others:F2} lv");
            Console.WriteLine($"Average: {average:F2} lv");
        }
    }
}
