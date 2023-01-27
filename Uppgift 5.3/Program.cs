using System;

namespace Uppgift_5._3_
{
    class Program
    {
        static void Main(string[] args)
        {

           
            {
                int[]xtal = new int[3];
                Console.WriteLine("skriv in 3 tal");

               xtal[0] = int.Parse(Console.ReadLine());
               xtal[1] = int.Parse(Console.ReadLine());
               xtal[2] = int.Parse(Console.ReadLine());


            Console.WriteLine("summan av dina tal " + (xtal[0] + xtal[1] + xtal[2]));


            }
            
        }

    }
}