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
        const int FPS       = 60;
        const int TICKSPEED = 1000 / FPS;

        // GAME ASSET DECLARATIONS /////////////////////////////////////////////

        internal Sprite forestParalax1;
        internal Sprite forestParalax2;
        internal Sprite forestParalax3;

        internal Sprite ItemCollectionMenu;

        internal Item firstSword;
        internal Item firstShield;

        internal Item earlyHealingPotion;
        internal Item BluntSword;
        internal Item BlurryMap;

        // MEMBERS /////////////////////////////////////////////////////////////

        private Thread InputThread;
        private Thread PhysicsThread;
        private Thread TickerThread;

        private bool isRunning  = false;
        private int gameTick = 0;

        private Dictionary<string, bool> pressedKeys = new Dictionary<string, bool>();

        private ConsoleColor originalForgroundColor;
        private ConsoleColor originalBackgroundColor;

        public AdventureBookGame()
        {
            // initalize threads
            InputThread     = new Thread(InputLoop);
            PhysicsThread   = new Thread(GameLoop);

            // store the pressed keys
            foreach (string key in new string[] { "select", "return", "up", "down", "left", "right" }) pressedKeys.Add(key, false);

            // create the game assets

            // sprites

            forestParalax1 = new Sprite("distantMountains", "Assets/scenes/distantMountain.txt");
            forestParalax2 = new Sprite("distantTrees", "Assets/scenes/DistantTrees.txt");


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
            Screen.Clear();

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
            PhysicsThread.Start();

            // start the game logic
            BeginGame();
        }

        /// <summary>
        ///  runs the game loop that is called every frame
        /// </summary>
        public void GameLoop()
        {
            do
            {
                // reset the pressed keys
                pressedKeys.Keys.ToList().ForEach(key => pressedKeys[key] = false);

                // render the screen
                Screen.Render();

                // pause
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
        /// Called to start the game logic like displaying sprites, telling the story, picking up items etc.
        /// </summary>
        public void BeginGame()
        {
            // opening paralax scene

            int paralaxProgress = -100;

            while (paralaxProgress < 200)
            {
                if (Step() % 10 == 0) forestParalax1.PrintSprite(paralaxProgress++, 0);
            }
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

        // misc

        /// <summary>
        /// steps the physics world to keep animates at a smooth rate
        /// </summary>
        private int Step()
        {
            gameTick++;
            Thread.Sleep(TICKSPEED);
            return gameTick;
        }
    }
}
