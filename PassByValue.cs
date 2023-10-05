using System;

namespace ConsoleApplication1
{
    class Program
    {
        // Method with two reference parameters
        static void disp( int p1,  int p2)
        {
            p1 = p1 + 10;
            p2 = p2 + 10;
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;

            Console.WriteLine("Before Method Calls:");
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);

            // Call the disp method with no reference parameters
            disp( x,  y);

            Console.WriteLine("After Method Calls:");
            Console.WriteLine("x (after disp): " + x); // x is modified
            Console.WriteLine("y (after disp): " + y); // y is modified

           
        }
    }
}

o/p:
Before Method Calls:
x: 10
y: 20
After Method Calls:
x (after disp): 10
y (after disp): 20
