using System;

namespace Week3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Sisesta Pin-kood:");
            int userPin = Convert.ToInt32(Console.ReadLine());

           /* if(userPin == 0000)
            {
                Console.WriteLine("Tere tulemast!");

            }
            else
            {
                Console.WriteLine("Vale Pin kood. Proovi uuesti!");
            }*/

            if(userPin != 0000){


                Console.WriteLine("Tere tulemast!");
                
            } 
        }
    }
}
