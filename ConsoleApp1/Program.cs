using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Foo(5);
        }

        static void Foo(int n)
        {
            n *= 2;
            Foo(n);
        }
    }
}
