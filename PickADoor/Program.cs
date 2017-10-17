using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickADoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a Door");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Behind door 1 is Bo, Ronin and Txai Chillin");




            }
            else if (choice == "2")
            {
                Console.WriteLine("Behind door 2 is Bo, Ronin and Txai doing a circle jerk ");
 



            }
            else if (choice == "3")
            {
                Console.WriteLine("Behind door 2 is Bo, Ronin and Txai doing a soggy sao with bo's mum ");
 



            }
            else
            {
                Console.WriteLine("bo is gay");
            }


            // wait at end
            Console.ReadKey();
        }
    }
}
