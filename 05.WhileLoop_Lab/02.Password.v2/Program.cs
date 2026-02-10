namespace _02.Password.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            string attemptPass = Console.ReadLine();

            while (attemptPass != password)
            {
                attemptPass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {username}!");
        }
    }
}
