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
            foreach (string key in new string[] { "w", "a", "s", "d", "space", "return", "up", "down", "left", "right" }) pressedKeys.Add(key, false);

            // create the game assets



            // start the game
            // [ This method could be configured to be the entry point of my game from the "library" menu ]

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



                // reset the pressed keys
                pressedKeys.Keys.ToList().ForEach(key => pressedKeys[key] = false);

                Thread.Sleep(100);
                Console.Clear();
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
                        pressedKeys["w"] = pressedKeys["up"] = true;
                        break;

                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        pressedKeys["a"] = pressedKeys["left"] = true;
                        break;

                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        pressedKeys["s"] = pressedKeys["down"] = true;
                        break;

                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        pressedKeys["d"] = pressedKeys["right"] = true;
                        break;

                    case ConsoleKey.Spacebar:
                    case ConsoleKey.Enter:
                        pressedKeys["space"] = pressedKeys["return"] = true;
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
        public bool IsSelectPressed()   => pressedKeys["space"] || pressedKeys["return"];
        public bool IsUpPressed()       => pressedKeys["up"]    || pressedKeys["w"];
        public bool IsDownPressed()     => pressedKeys["down"]  || pressedKeys["s"];
        public bool IsRightPressed()    => pressedKeys["right"] || pressedKeys["d"];
        public bool IsLeftPressed()     => pressedKeys["left"]  || pressedKeys["a"];
    }
}
