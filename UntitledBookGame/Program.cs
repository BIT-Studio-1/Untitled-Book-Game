using System;
using System.IO;
using System.Threading;

namespace UntitledBookGame
{
    public partial class Program
    {
        private static int  width = Console.WindowWidth;
        private static int  height = Console.WindowHeight;

        private static bool selecting = false;
        private static int  selection = 0;

        int Selection
        {
            get => selection;
            set
            {
                if (value < 0)      selection = 4;
                else if (value > 4) selection = 0;
                else                selection = value;
            }
        }

        static void Main(string[] args)
        {
            // store methods to load books in this array
            Action[] Books = new Action[4]
            {
                RunCatGame, RunHorrorGame, RunMurderMysteryGame, RunPrisonEscapeGame
            };


            /* NEW BOOK SELECTION CODE
            do
            {
                // if the window has changed size, clear the screen
                if (Console.WindowWidth != width || Console.WindowHeight != height)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Console.Clear();
                }

                // print the bookshelf
                PrintBookShelf();

                // check for input, updating the selector
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Enter:
                        selecting = false;
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        selection--;
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        selection++;
                        break;
                }
            }
            while (selecting);
            */

            // Basic book selection loop
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

        // prints the bookshelf to the center bottom of the screen
        private static void PrintBookShelf()
        {
            int row = 0;
            foreach (string line in File.ReadAllLines("assets/TextFile1.txt"))
            {
                Console.SetCursorPosition((Console.WindowWidth / 2 - line.Length / 2), Console.WindowHeight - 10 + row++);
                Console.WriteLine(line);
            }
        }
    }
}
