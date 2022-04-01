using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести PIN-код.
            //Если введеный PIN-код "1234", то приложение приветствует пользователя 
            //*и спрашивает его имя. А затем приветствует пользователя по имени.
            //В ином случае, консоль выводит на экран сообщение об ошибке Invaled PIN.


            Console.WriteLine("Please enter you PIN-kod:");
            string userName = Console.ReadLine();

            if (userName == "1234")
            {
                Console.WriteLine("Hallo! Please, enter your name");
                string userYourname = Console.ReadLine();
                Console.WriteLine("Hallo, Tanja!");
                string userTanja = Console.ReadLine();
                

                
                
                
                   
              

               
               




            }else
            {
                Console.WriteLine("Invaled PIN.");
            }
        }
    }
}
