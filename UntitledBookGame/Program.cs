using System;
using System.IO;
using System.Threading;

namespace UntitledBookGame
{
    public partial class Program
    {
        private static int  width       = Console.WindowWidth,
                            height      = Console.WindowHeight;

        private static bool selecting   = true;
        private static int  selection   = 0;

        private static int[,] BookSelectors = new int[4,2]
        {
            { 0,8 }, { 8,6 }, { 14,8 }, { 22,7 }
        };

        private static Action[] Books   = new Action[4]
        {
            RunCatGame,
            RunHorrorGame,
            RunMurderMysteryGame,
            RunPrisonEscapeGame
        };

        private static int Selection
        {
            get => selection;
            set
            {
                if (value < 0)
                {
                    selection = Books.Length - 1;
                }
                else if (value > Books.Length - 1)
                {
                    selection = 0;
                }
                else
                {
                    selection = value;
                }
            }
        }

        static void Main(string[] args)
        {
            do
            {
                // if the window has changed size, clear the screen
                // TODO ::  put this method in seperate thread
                //          to run concurrantly with input
                //          detection
                if (Console.WindowWidth != width || Console.WindowHeight != height)
                {
                    width = Console.WindowWidth;
                    height = Console.WindowHeight;
                    Console.Clear();
                }

                // print the bookshelf
                PrintBookShelf();
                PrintSelector(Selection);

                // check for input
                switch (Console.ReadKey(false).Key)
                {
                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Enter:
                        selecting = false;
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        Selection--;
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        Selection++;
                        break;
                }
                Console.Clear();
            }
            while (selecting);

            // open the selected book
            Console.Clear();
            Books[Selection]();
        }


        // prints the bookshelf to the center bottom of the screen
        private static void PrintBookShelf()
        {
            int row = 0;
            foreach (string line in File.ReadAllLines("assets/bookshelf.txt"))
            {
                Console.SetCursorPosition((Console.WindowWidth / 2 - line.Length / 2), Console.WindowHeight - 10 + row++);
                Console.WriteLine(line);
            }
        }


        // prints the book selector to the screen
        private static void PrintSelector(int index)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;

            int bookshelfWidth  = File.ReadAllLines("assets/bookshelf.txt")[0].Length,
                X               = (Console.WindowWidth / 2 - bookshelfWidth / 2) + 3,
                Y               = Console.WindowHeight - 19;

            // draw top of selector

            Console.SetCursorPosition(X + BookSelectors[index, 0], Y);
            Console.Write(new string('#', BookSelectors[index, 1]));

            // draw sides

            for (Y++; Y < 14; Y++)
            {
                Console.SetCursorPosition(X + BookSelectors[index, 0], Y);
                Console.Write('#');

                Console.SetCursorPosition(X + BookSelectors[index, 0] + BookSelectors[index, 1] - 1, Y);
                Console.Write('#');
            }

            // draw bottom

            Console.SetCursorPosition(X + BookSelectors[index, 0], Y);
            Console.Write(new string('#', BookSelectors[index, 1]));

            // reset color

            Console.ResetColor();
        }
    }
}
