namespace _07.TrekkingMania.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            List<int> mussala = new();
            List<int> montblanc = new();
            List<int> kilimangjaro = new();
            List<int> k2 = new();
            List<int> everest = new();

            for (int i = 0; i < groups; i++)
            {
                int groupMembers = int.Parse(Console.ReadLine());

                if (groupMembers <= 5)
                {
                    mussala.Add(groupMembers);
                }
                else if (groupMembers <= 12)
                {
                    montblanc.Add(groupMembers);
                }
                else if (groupMembers <= 25)
                {
                    kilimangjaro.Add(groupMembers);
                }
                else if (groupMembers <= 40)
                {
                    k2.Add(groupMembers);
                }
                else
                {
                    everest.Add(groupMembers);
                }
            }

            int totalMembers = mussala.Sum() + montblanc.Sum() + kilimangjaro.Sum() + k2.Sum() + everest.Sum();
            double mussalaPercent = mussala.Sum() * 100.0 / totalMembers;
            double montblancPercent = montblanc.Sum() * 100.0 / totalMembers;
            double kilimandjaroPercent = kilimangjaro.Sum() * 100.0 / totalMembers;
            double k2Percent = k2.Sum() * 100.0 / totalMembers;
            double everestPercent = everest.Sum() * 100.0 / totalMembers;

            Console.WriteLine($"{mussalaPercent:F2}%");
            Console.WriteLine($"{montblancPercent:F2}%");
            Console.WriteLine($"{kilimandjaroPercent:F2}%");
            Console.WriteLine($"{k2Percent:F2}%");
            Console.WriteLine($"{everestPercent:F2}%");
        }
    }
}
