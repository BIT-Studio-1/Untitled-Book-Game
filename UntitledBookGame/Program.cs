using System;

namespace UntitledBookGame
{
    public partial class Program
    {
        static void Main(string[] args)
        {
            // store methods to load books in this array
            Action[] Books = new Action[5]
            {
                RunCatGame, RunHorrorGame, RunMurderMysteryGame, RunPrisonEscapeGame, RunAdventureGame
            };

            // Basic book selection loop

            Console.WriteLine("Please select a book: ");
            int input = int.Parse(Console.ReadLine());
            Console.Clear();
            Books[input]();
        }
    }
}
