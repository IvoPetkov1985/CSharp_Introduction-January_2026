namespace _08.FuelTank_Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double gasPrice = 0.93;
            double gasolinePrice = 2.22;
            double dieselPrice = 2.33;

            double gasDiscount = 0.08;
            double gasolineDiscount = 0.18;
            double dieselDiscount = 0.12;

            double pricePerLiter = 0.0;

            string fuelType = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            string cardStatus = Console.ReadLine();

            switch (fuelType)
            {
                case "Gas":
                    pricePerLiter = gasPrice;

                    if (cardStatus == "Yes")
                    {
                        pricePerLiter -= gasDiscount;
                    }

                    break;

                case "Gasoline":
                    pricePerLiter = gasolinePrice;

                    if (cardStatus == "Yes")
                    {
                        pricePerLiter -= gasolineDiscount;
                    }

                    break;

                case "Diesel":
                    pricePerLiter = dieselPrice;

                    if (cardStatus == "Yes")
                    {
                        pricePerLiter -= dieselDiscount;
                    }

                    break;
            }

            double totalPrice = pricePerLiter * quantity;

            if (quantity >= 20 && quantity <= 25)
            {
                totalPrice *= 0.92;
            }
            else if (quantity > 25)
            {
                totalPrice *= 0.90;
            }

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
