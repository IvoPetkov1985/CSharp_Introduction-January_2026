namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string inputPass = Console.ReadLine();

            while (true)
            {
                if (inputPass == password)
                {
                    Console.WriteLine($"Welcome {username}!");
                    break;
                }

                inputPass = Console.ReadLine();
            }
        }
    }
}
