namespace _02.Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int daysCount = int.Parse(Console.ReadLine());

            int doctorsCount = 7;
            int treated = 0;
            int untreated = 0;

            for (int i = 1; i <= daysCount; i++)
            {
                if (i % 3 == 0 && untreated > treated)
                {
                    doctorsCount++;
                }

                int currentPatients = int.Parse(Console.ReadLine());

                if (currentPatients > doctorsCount)
                {
                    treated += doctorsCount;
                    untreated += currentPatients - doctorsCount;
                }
                else
                {
                    treated += currentPatients;
                }
            }

            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
