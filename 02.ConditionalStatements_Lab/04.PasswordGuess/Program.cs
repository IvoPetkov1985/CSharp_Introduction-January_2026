namespace _04.PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputPassword = Console.ReadLine();
            string searchedPassword = "s3cr3t!P@ssw0rd";
            string output = string.Empty;

            if (inputPassword == searchedPassword)
            {
                output = "Welcome";
            }
            else
            {
                output = "Wrong password!";
            }

            Console.WriteLine(output);
        }
    }
}
