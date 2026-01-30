namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double singlePrice = 0;

            switch (flowerType)
            {
                case "Roses": singlePrice = 5.00; break;
                case "Dahlias": singlePrice = 3.80; break;
                case "Tulips": singlePrice = 2.80; break;
                case "Narcissus": singlePrice = 3.00; break;
                case "Gladiolus": singlePrice = 2.50; break;
            }

            double finalPrice = singlePrice * count;

            if (flowerType == "Roses" && count > 80)
            {
                finalPrice *= 0.90;
            }
            else if (flowerType == "Dahlias" && count > 90)
            {
                finalPrice *= 0.85;
            }
            else if (flowerType == "Tulips" && count > 80)
            {
                finalPrice *= 0.85;
            }
            else if (flowerType == "Narcissus" && count < 120)
            {
                finalPrice *= 1.15;
            }
            else if (flowerType == "Gladiolus" && count < 80)
            {
                finalPrice *= 1.20;
            }

            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowerType} and {budget - finalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:F2} leva more.");
            }
        }
    }
}
