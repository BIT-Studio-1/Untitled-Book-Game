using System;
using System.Threading;

namespace PrisonEscapeBook
{
    class Program
    {
        static void Main()
        {
            char I;
            string temp;

            Console.WriteLine("Welcome to Prison Escape!".PadLeft(50));
            Console.WriteLine("type 'A' to begin...");
            Console.WriteLine("Or type 'I' for Instructions");
            temp = Console.ReadLine();

            I = Convert.ToChar(temp);
            if ((I == 'a')||(I == 'A'))
            {
                Console.Clear();
                Console.WriteLine("Loading.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading.");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading..");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine("Loading...");
                Thread.Sleep(500);
                Console.Clear();

                Console.WriteLine("");
            }
            else if ((I == 'i') || (I == 'I'))
            {
                Console.Clear();
                Console.WriteLine("Instructions");
            }
            Console.ReadLine();

             
        }
    }
}
