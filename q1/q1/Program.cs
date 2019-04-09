/*sagar devkota*/
/**student id=30004439*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program will give the result of base^exponent");
            
            Console.WriteLine("Enter you base number");
            Double num1 = Double.Parse(Console.ReadLine()); //base num


            Console.WriteLine("Enter your exponent");
            int exp = int.Parse(Console.ReadLine()); //exp num

            Console.WriteLine($"The result of exponent is {num1}^{exp}={num1 * exp}"); //calculating exponent
            Console.ReadLine();

        }
    }
}
