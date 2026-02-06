namespace _07.TrekkingMania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsCount = int.Parse(Console.ReadLine());

            int mussala = 0;
            int montblanc = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;

            for (int i = 0; i < groupsCount; i++)
            {
                int groupSize = int.Parse(Console.ReadLine());

                if (groupSize <= 5)
                {
                    mussala += groupSize;
                }
                else if (groupSize <= 12)
                {
                    montblanc += groupSize;
                }
                else if (groupSize <= 25)
                {
                    kilimandjaro += groupSize;
                }
                else if (groupSize <= 40)
                {
                    k2 += groupSize;
                }
                else
                {
                    everest += groupSize;
                }
            }

            int allTrekkers = mussala + montblanc + kilimandjaro + k2 + everest;
            double mussalaPercentage = mussala * 100.0 / allTrekkers;
            double montblancPercentage = montblanc * 100.0 / allTrekkers;
            double kilimandjaroPercentage = kilimandjaro * 100.0 / allTrekkers;
            double k2Percentage = k2 * 100.0 / allTrekkers;
            double everestPercentage = everest * 100.0 / allTrekkers;

            Console.WriteLine($"{mussalaPercentage:F2}%");
            Console.WriteLine($"{montblancPercentage:F2}%");
            Console.WriteLine($"{kilimandjaroPercentage:F2}%");
            Console.WriteLine($"{k2Percentage:F2}%");
            Console.WriteLine($"{everestPercentage:F2}%");
        }
    }
}
