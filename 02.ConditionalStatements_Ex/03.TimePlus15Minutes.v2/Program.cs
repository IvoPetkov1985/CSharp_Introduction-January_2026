namespace _03.TimePlus15Minutes.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());
            int addedMinutes = 15;

            int allInMinutes = inputHours * 60 + inputMinutes + addedMinutes;
            int hours = allInMinutes / 60;
            int minutes = allInMinutes % 60;

            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
