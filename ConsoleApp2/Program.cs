using ConsoleApp2.Models;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User("saMir   ", "   KarİmOv", "Samir0022");
            user.ChangePassword("Samir0022", "Karimov0022");

            Console.WriteLine(user.UserName);
        }
    }
}
