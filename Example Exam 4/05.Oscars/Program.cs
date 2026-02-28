namespace _05.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double actorPoints = double.Parse(Console.ReadLine());
            int juryCount = int.Parse(Console.ReadLine());
            double nomineePoints = 1250.5;
            bool isNominared = false;

            for (int i = 0; i < juryCount; i++)
            {
                string inputName = Console.ReadLine();
                double inputPoints = double.Parse(Console.ReadLine());
                double juryPoints = inputName.Length * inputPoints / 2;
                actorPoints += juryPoints;

                if (actorPoints > nomineePoints)
                {
                    isNominared = true;
                    break;
                }
            }

            if (isNominared == true)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {actorPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {nomineePoints - actorPoints:F1} more!");
            }
        }
    }
}
