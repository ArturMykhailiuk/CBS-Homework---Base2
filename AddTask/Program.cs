using System;

namespace AddTask
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine(user.Login);
            Console.WriteLine(user.FirstName);
            Console.WriteLine(user.LastName);
            Console.WriteLine(user.Age);
            Console.WriteLine(user.Date1);
        }
    }
}
