using System;

namespace ParametricArrayExample
{
    class Program
    {
        // Method with a parametric array
        static void Pass(params int[] p1)
        {
            Console.WriteLine("Values are:");
            foreach (int i in p1)
            {
                Console.WriteLine("Value=" + i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Pass(10);
            Pass(10, 20);
            Pass();
            Pass(arr);
        }
    }
}

Values are:
Value=10
Values are:
Value=10
Value=20
Values are:
Values are:
Value=1
Value=2
Value=3
Value=4
Value=5
