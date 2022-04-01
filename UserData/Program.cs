using System;

namespace UserData
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение спрашивает у пользователя его имя
            //если имя пользователя совпадает с зарегистрированным именем пользователя admin
            //приложение приветствует пользователя, выводя в консоль слово Welcome!
            //в ином случае, консоль вы
            //водит ошибку Oops!  Invalid username.

            Console.WriteLine("Please enter your user name:");
            string userName = Console.ReadLine();

            if (userName == "admin")
            {
                Console.WriteLine("Welcome!");
            } else
            {
                Console.WriteLine("Oops! Invalid username .");
            }

            Console.WriteLine("Have a nice day!");


        }
    }
}
