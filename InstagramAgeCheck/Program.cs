using System;

namespace InstagramAgeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //прмложение спрашивает у пользователя его возраст 
            //если пользователь младше 13 лет, то приложение сообщает пользователю, 
            //что он еще слищком молод, чтобы имеьб аккаунт в Instagram
            //если пользователю 13 или больше лет, то приложение приветствует его.

            Console.WriteLine("Please, enter your age:");
            int userAge = Convert.ToInt32(Console.ReadLine());


            if (userAge < 13)
            {
                Console.WriteLine("You too young for Instagram.");
            } else if (userAge > 13) 
            {
                Console.WriteLine("Welcome to Instagram!");

            }
            else
            {
                Console.WriteLine("Congratolations! You may use Instagram now.");
            }
            Console.WriteLine("Have a nice day!");  
                
        }
    }
}
 