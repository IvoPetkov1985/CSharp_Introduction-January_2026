namespace _06.Cake.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());

            int cakePieces = width * length;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "STOP")
            {
                int pieces = int.Parse(input);
                cakePieces -= pieces;

                if (cakePieces < 0)
                {
                    Console.WriteLine($"No more cake left! You need {cakePieces * -1} pieces more.");
                    break;
                }
            }

            if (input == "STOP")
            {
                Console.WriteLine($"{cakePieces} pieces are left.");
            }
        }
    }
}
