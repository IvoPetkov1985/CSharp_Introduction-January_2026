namespace _03.TravelAgency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            bool isTownValid = true;
            bool areDaysValid = true;
            bool isPackageValud = true;

            if (days < 1)
            {
                areDaysValid = false;
            }

            double pricePerDay = 0;

            if (town == "Bansko" || town == "Borovets")
            {
                if (package == "withEquipment")
                {
                    pricePerDay = 100;

                    if (vipDiscount == "yes")
                    {
                        pricePerDay *= 0.90;
                    }
                }
                else if (package == "noEquipment")
                {
                    pricePerDay = 80;

                    if (vipDiscount == "yes")
                    {
                        pricePerDay *= 0.95;
                    }
                }
                else
                {
                    isPackageValud = false;
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (package == "withBreakfast")
                {
                    pricePerDay = 130;

                    if (vipDiscount == "yes")
                    {
                        pricePerDay *= 0.88;
                    }
                }
                else if (package == "noBreakfast")
                {
                    pricePerDay = 100;

                    if (vipDiscount == "yes")
                    {
                        pricePerDay *= 0.93;
                    }
                }
                else
                {
                    isPackageValud = false;
                }
            }
            else
            {
                isTownValid = false;
            }

            if (isPackageValud && isTownValid && areDaysValid)
            {
                if (days > 7)
                {
                    days--;
                }

                double totalSum = days * pricePerDay;
                Console.WriteLine($"The price is {totalSum:F2}lv! Have a nice time!");
            }
            else if (!isTownValid || !isPackageValud)
            {
                Console.WriteLine("Invalid input!");
            }
            else if (!areDaysValid)
            {
                Console.WriteLine("Days must be positive number!");
            }
        }
    }
}
