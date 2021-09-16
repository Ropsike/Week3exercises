using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma sünniaasta:");
            int userYearOfBirth = Convert.ToInt32(Console.ReadLine());
            int userAge = 2021 - userYearOfBirth;
            if(userAge >= 13)
            {
                Console.WriteLine("Tere tulemast Instagram'i");

            }
            else
            {
                Console.WriteLine("Oled liiga noor.");

            }


        }
    }
}
