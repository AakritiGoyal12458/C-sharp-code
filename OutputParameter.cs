using System;

class Program
{
    static void Square(int x, out int y)
    {
        y = x * x;
    }

    static void Main(string[] args)
    {
        int m=10;
        Square(10, out m);
        Console.WriteLine("M = " + m);
    }
}
