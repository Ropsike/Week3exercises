using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta kasutajatunnus:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta parool:");
            string password = Console.ReadLine();
            
            /*if(UserName == "admin"  && password == "admin1234")
            {
                Console.WriteLine("Tere tulemast!");

            }

            else
            {
                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");

            }*/

            if(UserName != "admin"  password != "admin1234)
             {

                Console.WriteLine("Vale kasutajatunnus või parool. Proovi uuesti!");
             }

            else
            {
                Console.WriteLine("Tere tulemast!");

            }













        }
    }
}
