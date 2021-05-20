using System;
using System.Threading;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;


using AdventureBook.GameObjects;

//
//  Created by Aardhyn Lavender
//  19/05/2021
//

namespace AdventureBook.Game
{
    public class AdventureBookGame
    {
        // GAME ASSET DECLARATIONS /////////////////////////////////////////////

        internal Sprite ItemCollectionMenu;

        internal Item firstSword;
        internal Item firstShield;

        internal Item earlyHealingPotion;
        internal Item BluntSword;
        internal Item BlurryMap;

        // MEMBERS /////////////////////////////////////////////////////////////

        private Thread InputThread;
        private bool isRunning = false;

        private Dictionary<string, bool> pressedKeys = new Dictionary<string, bool>();

        private ConsoleColor originalForgroundColor;
        private ConsoleColor originalBackgroundColor;

        public AdventureBookGame()
        {
            // create the input thread
            InputThread = new Thread(InputLoop);

            // store the pressed keys
            foreach (string key in new string[] { "select", "return", "up", "down", "left", "right" }) pressedKeys.Add(key, false);

            // create the game assets

            // UI

            ItemCollectionMenu = new Sprite("itemCollectionMenu", 
                                            "Assets/UserInterface/ItemCollection.txt"
                                            );

            // items

            BluntSword = new Item("Blunt Sword",
                                "Assets/Sprites/bluntSword.txt",
                                () => Protagonist.SetAttack(5),
                                "You weld the blunt sword - its use escapes reason"
                                );

            Protagonist.PickUpItem(BluntSword);

            // start the game

            Screen.SetToConsole(); // configure the Screen buffer

            OpenBook();
        }

        // METHODS /////////////////////////////////////////////////////////////

        /// <summary>
        ///  called from outside the class to start the game
        /// </summary>
        public void OpenBook()
        {
            Console.CursorVisible = false;

            // grab the current console colors
            originalBackgroundColor = Console.BackgroundColor;
            originalForgroundColor = Console.ForegroundColor;

            // update the colors
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // start the game and input loops
            isRunning = true;
            InputThread.Start();
            GameLoop();
        }

        /// <summary>
        ///  runs the game loop that is called every frame
        /// </summary>
        public void GameLoop()
        {
            do
            {
                // do game logic...

                ItemCollectionMenu.PrintSprite(10, 10);

                // reset the pressed keys
                pressedKeys.Keys.ToList().ForEach(key => pressedKeys[key] = false);

                Thread.Sleep(100);
            }
            while (isRunning);
        }


        /// <summary>
        /// Processes the pressed keys updating a dictionary of pressed keys
        /// </summary>
        public void InputLoop()
        {
            do
            {
                ConsoleKeyInfo character = Console.ReadKey(false);

                switch (character.Key)
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        pressedKeys["up"] = true;
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        pressedKeys["left"] = true;
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        pressedKeys["down"] = true;
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        pressedKeys["right"] = true;
                        break;

                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Enter:
                        pressedKeys["select"] = true;
                        break;

                    default:
                        break;
                }
            }
            while (isRunning);
        }


        /// <summary>
        /// called within the game to return the to "Library", possibly saving user data.
        /// </summary>
        public void CloseBook()
        {
            isRunning = false;

            do
            {
                // await the input thread terminating...
            }
            while (InputThread.IsAlive);

            // return the colors to the previous
            Console.ForegroundColor = originalForgroundColor;
            Console.BackgroundColor = originalBackgroundColor;
        }

        // checks whether the specified keys are being pressed or not
        public bool IsSelectPressed()   => pressedKeys["select"];
        public bool IsUpPressed()       => pressedKeys["up"];
        public bool IsDownPressed()     => pressedKeys["down"];
        public bool IsRightPressed()    => pressedKeys["right"];
        public bool IsLeftPressed()     => pressedKeys["left"];


        /// <summary>
        /// Copies a 2D jagged array data structure to another 2D jagged array at
        /// a specified cooordinate supporting transparancy on space characters
        /// </summary>
        /// <param name="source">Array to copy</param>
        /// <param name="destination">Array to paste</param>
        /// <param name="destX">X location on the destination to paste the source</param>
        /// <param name="destY">Y location on the destination to paste the source</param>
        /// <param name="replaceWhiteSpace">whether spaces should be treated as transparent characters</param>
        public static void JaggedCopy(
            char[][] source,
            char[][] destination,
            int destX = 0,
            int destY = 0,
            bool replaceWhiteSpace = true
            )
        {
            char[][] safeSource = source;

            for (int y = 0; y < source.Length; y++)
            {
                try
                {
                    // replace whitespace with 'see-through' of matrix below
                    if (replaceWhiteSpace)
                    {
                        do
                        {
                            int index = safeSource[y].ToList().IndexOf(' ');
                            if (index == -1) break;

                            safeSource[y][index] = destination[destY + y][destX + index];

                        } while (true);
                    }

                    try { Array.ConstrainedCopy(safeSource[y], 0, destination[destY + y], destX, source[y].Length); }
                    catch (Exception) { /* unhandled exception */ }
                }
                catch (System.ArgumentException) { return; }
            }
        }
    }
}
