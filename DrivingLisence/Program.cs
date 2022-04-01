using System;

namespace DrivingLisence
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести его год рождения
            //приложение вычисляет возраст пользователя(2022-год рождения пользователя)
            //если пользователь моложе 18 лет,то в консоли выводится "too young to drive"
            //если пользователь старше 18 лет, то в консоли выводится "drive carefully"
            //а если пользователю 18 лет, то в консоли выводится "Congratulations, you my apply
            //for you driving lisence now"

            //*int result = 2022 - yearOfBirth;
            Console.WriteLine("Enter you date of birth:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            if (2022 - YearOfBirth < 18)
            {
                Console.WriteLine("Too young to drive.");
            }
            else if (2022 - YearOfBirth > 18)
            {
                Console.WriteLine("Drive carefuly!");
            }else
            {
                Console.WriteLine("Congradulations,you my apply for you drive lisence now.");
            }



            
            
            
        }
    }
}

