using System;
using System.IO;
using System.Threading;

namespace UntitledBookGame
{
    public partial class Program
    {
        public static int width = Console.WindowWidth;
        public static int height = Console.WindowHeight;

        static void Main(string[] args)
        {
            // store methods to load books in this array
            Action[] Books = new Action[4]
            {
                RunCatGame, RunHorrorGame, RunMurderMysteryGame, RunPrisonEscapeGame
            };

            // Basic book selection loop
            /*
            bool selecting = false;

            
            do
            {
                PrintBookShelf();
                Thread.Sleep(5);

                if (Console.WindowWidth != width || Console.WindowHeight != height)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Console.Clear();
                }

                switch (Console.ReadKey(false).KeyChar)
                {
                    case ' ': break ;
                }
            }
            while (selecting);
            */

            do
            {
                Console.Clear();
                Console.WriteLine("Please select a book: ");
                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                Books[input]();
            }
            while (true);
        }

        private static void PrintBookShelf()
        {
            int row = 0;
            foreach (string line in File.ReadAllLines("assets/TextFile1.txt"))
            {
                Console.SetCursorPosition((Console.WindowWidth / 2 - line.Length / 2), Console.WindowHeight - 10 + row++);
                Console.WriteLine(line);
            }
        }

        private static void ClearScreen()
        {
            int row = 0;
        }
    }
}
