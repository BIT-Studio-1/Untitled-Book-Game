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

            // book selection loop...

            int selectedBook = 0;







            // run the selected book
            Books[selectedBook]();
        }
    }
}
