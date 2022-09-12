using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Username DAXIL ET");
                string username = Console.ReadLine();
                if (username.Length >= 8)
                {
                    while (true) {
                        bool isUpperCaseChar = false;
                        Console.WriteLine("Password DAXIL ET");
                        string password = Console.ReadLine();
                        if (password.Length>=8)
                        {
                            User user = new User();
                            user.userName = username;
                            user.password = password;
                            Console.WriteLine(user.userName);
                            Console.WriteLine(user.password);
                            break;
                        }
                    }
                }
            }
        }
    }
}
