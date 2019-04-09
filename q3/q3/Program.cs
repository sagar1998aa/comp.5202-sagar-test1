using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>solving the algebraic expression:2(x-3)+ X =12   <<<<<<<<");
            Console.WriteLine("__________________________2<x-n>+ <m>=12___________________________");
            Console.WriteLine("LOOKING AT THE ABOVE BRACKETS....");


            Console.WriteLine("enter a value of n:");
            int n = 3; 

            Console.WriteLine("enter a value m:");
            int m = double.Parse(Console.ReadLine());
            decimal b = 2(n - m);
            decimal c =  m;
            Console.WriteLine("that standard form is:x^22(x-3)+m=12 ");

           Console.ReadLine();

            Console.WriteLine("Enter the value to guess");
            int g, j = 5;
            Console.WriteLine("\nguess my number");
            g = int.Parse(Console.ReadLine());

            if (g == j)
            {
                Console.WriteLine("gussing value is Right");
            }
            else
            {
                Console.WriteLine("gussing value is wrong");
                Console.ReadLine();
            }

        }
    }
}
