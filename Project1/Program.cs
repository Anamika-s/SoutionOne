// #include <stdio.h>
using System;  // system is library aka namespace
namespace Project1   //
                     // We get namespace name as of project name
{
    internal class Program   // get a class by def its name is Program
    {
        static void Main(string[] args)   // Main method is entry and 
                     // exit point of application
        {
            // intellisense > we get sugestions
            //Console.Write("Hello\n");
            //Console.Write("Hello\n");
            //Console.Write("Hello\n");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //Console.WriteLine("Hello");
            //int x = 10;
            //Console.WriteLine(x);
            //Console.WriteLine("Value of x is " + x);
            //Console.WriteLine("Value of x is {0}", x);
            //// positional parameter

            //// printf("Value of x is %d",x);
            //// string interploation
            //Console.WriteLine($"Value of x is {x}");

            int x = 10, y = 20;
            Console.WriteLine(x+y);
            Console.WriteLine("Sum of " + x + " and " + y + " is " + (x+y));
            Console.WriteLine("Sum of {0} and {1} is {2}", x,y ,(x+y));
            Console.WriteLine($"Sum of {x} and {y} is {x+ y}");
            Console.WriteLine($"Diference of {x} and {y} is {x-y}");
            Console.WriteLine($"Product of {x} and {y} is {x*y}");
            Console.WriteLine($"Remainder of {x} and {y} is {x%y}");
            Console.WriteLine($"Quotient of {x} and {y} is {x / y}");
            //Console.WriteLine("Hello, World!");
            // comments are statements ignored by compiler
            // Ctrl K + c > comment statements
            // ctrl K + u > uncomment statements


            // Console is a class that belongs to System library
            // WriteLine is a method that belongs to Console class
        }
    }
}
