using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Fun
{
    class Program
    {
        static void Main(string[] args)


        {
            Console.WriteLine("enter number1 :");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("enter number2 :");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine($"{num1} plus {num2} = " + (num1 + num2));
            Console.WriteLine($"{num1} minus {num2} =" + (num1 - num2));
            Console.WriteLine($"{num1} times {num2} =" + (num1 * num2));
            Console.WriteLine($"{num1} divide {num2} =" + (num1 / num2));



            Console.ReadKey();
        }
        
    }
}
