/*sagar Devkota*/
/* student id=30004439*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace que2
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("This program will give the sum of total of 5 prices");
            double total = 0;
           
            for (double num1 = 0; num1 <= 5; num1++) ;//using double
            {
                Console.WriteLine($"Enter the price of items {i}:");//displaying the price of items under loop
                total = total + double.Parse(Console.ReadLine());
                Console.ReadLine();
            }
            Console.WriteLine($"the sum of price {total}:" );//calculate total
        }
    }
}
