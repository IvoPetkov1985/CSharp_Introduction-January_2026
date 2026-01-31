namespace _08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTimeInMinutes = examHour * 60 + examMinutes;
            int arrivalTimeInMinutes = arrivalHour * 60 + arrivalMinutes;
            int diffInMinutes = examTimeInMinutes - arrivalTimeInMinutes;

            if (diffInMinutes >= 0 && diffInMinutes <= 30)
            {
                Console.WriteLine("On time");

                if (diffInMinutes > 0)
                {
                    Console.WriteLine($"{diffInMinutes} minutes before the start");
                }
            }
            else if (diffInMinutes > 30)
            {
                Console.WriteLine("Early");

                if (diffInMinutes >= 60)
                {
                    int hours = diffInMinutes / 60;
                    int minutes = diffInMinutes % 60;
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start");
                }
                else
                {
                    Console.WriteLine($"{diffInMinutes} minutes before the start");
                }
            }
            else if (diffInMinutes < 0)
            {
                Console.WriteLine("Late");

                if (diffInMinutes <= -60)
                {
                    int lateHours = Math.Abs(diffInMinutes / 60);
                    int lateMinutes = Math.Abs(diffInMinutes % 60);
                    Console.WriteLine($"{lateHours}:{lateMinutes:D2} hours after the start");
                }
                else
                {
                    Console.WriteLine($"{Math.Abs(diffInMinutes)} minutes after the start");
                }
            }
        }
    }
}
