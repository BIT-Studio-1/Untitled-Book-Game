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
        const int       FPS       = 60,
                        TICKSPEED = 1000 / FPS;

        // GAME ASSET DECLARATIONS /////////////////////////////////////////////

        internal Sprite gameTitle,

                        forestParalax1,
                        forestParalax2,
                        forestParalax3,

                        caveExterior,
                        IvyCaveWall,
                        loomingCliff,
                        bolders,
                        largeLockedDoor,

                        ItemCollectionMenu,
                        InventoryMenu,
                        
                        BossStatistics,
                        ProtagonistStatistics;

        // ITEMS ///////////////////////////////////////////////////////////////

        internal Item   firstSword,
                        firstShield,
                        healingHerb,
                        BluntSword,
                        treasureChest,
                        openTreasureChest,
                        emptyChest,
                        rustyKey;
                        

        // STORY COMPONENTS ////////////////////////////////////////////////////

        /* 
         * Indendation shows progression 
         */

        internal StoryComponent openingMonologue                                    = new StoryComponent("Opening Monologue"),
                                firstBranch                                         = new StoryComponent("Cave Entrance"),
                                    secondBranch                                    = new StoryComponent("Cave Entrance"),
                                        firstBoss                                   = new StoryComponent("First Boss"),
                                        secondBoss                                  = new StoryComponent("Second Boss"),
                                        overgrownPassage                            = new StoryComponent("Overgrown Passage"),
                                            largeCavern                             = new StoryComponent("Large Cavern"),
                                // "explore" * 10 for Treasure chest
                                ThirdBranch                                         = new StoryComponent("Third Branch"),
                                    thirdBoss                                       = new StoryComponent("Third Boss"),
                                        CavernCliff                                 = new StoryComponent("Cavern Cliff"),
                                            fourthBranch                            = new StoryComponent("Fourth Branch"),
                                                fifthBoss                           = new StoryComponent("Fifth Boss"),
                                                    sixthBoss                       = new StoryComponent("Sixth Boss"),
                                                //-> get treasure chest after this boss
                                                darkPassage                         = new StoryComponent("Dark Passage"),
                                    // -> Links to Line 59
                                    fourthBoss                                      = new StoryComponent("Forth Boss"),
                                    fifthBranch                                     = new StoryComponent("Fivth Branch"),
                                        deadEnd                                     = new StoryComponent("Dead End"),
                                        blockedPath                                 = new StoryComponent("Blocked Path"),
                                            lockedDoor                              = new StoryComponent("Locked Door"),
                                                UndergroundHub                      = new StoryComponent("Underground Hub"),
                                                    seventhBoss                     = new StoryComponent("Seventh Boss"),
                                                    eighthBoss                      = new StoryComponent("Eighth Boss"),
                                                    ninthBoss                       = new StoryComponent("Ninth Boss"),
                                                    sixthBranch                     = new StoryComponent("Sixth Branch"),
                                                        unguardedChest              = new StoryComponent("Unguarded Chest"),
                                                        tenthBoss                   = new StoryComponent("Tenth Boss"),
                                                        seventhBranch               = new StoryComponent("Seventh Branch"),
                                                            secondUnguardedChest    = new StoryComponent("Second Unguarded Chest"),
                                                                tenseBranch         = new StoryComponent("Tense Branch"),
                                                                    // two chests for actions
                                                                    FinalBoss       = new StoryComponent("Final Boss"),
                                     /* Joins from 59 -> */ eleventhBoss            = new StoryComponent("Eleventh Boss"),
                                                                caveExit            = new StoryComponent("Cave Exit");

        // MEMBERS /////////////////////////////////////////////////////////////

        private Thread  InputThread,
                        PhysicsThread;

        private bool    isRunning   = false;
        private int     gameTick    = 0;

        private Dictionary<string, bool> pressedKeys = new Dictionary<string, bool>();

        private ConsoleColor originalForgroundColor;
        private ConsoleColor originalBackgroundColor;
        
        // CONSTRUCTOR /////////////////////////////////////////////////////////

        public AdventureBookGame()
        {
            // initalize threads
            InputThread     = new Thread(InputLoop);
            PhysicsThread   = new Thread(GameLoop);

            // store the pressed keys
            foreach (string key in new string[] { "select", "escape", "return", "up", "down", "left", "right" }) pressedKeys.Add(key, false);

            // create the game assets

            // SPRITES /////////////////////////////////////////////////////////

            forestParalax1 = new Sprite("distantMountains", "Assets/scenes/distantMountain.txt");
            forestParalax2 = new Sprite("distantTrees", "Assets/scenes/DistantTrees.txt");
            forestParalax3 = new Sprite("distantTrees2", "Assets/scenes/closerTrees.txt");


            // USER INTERFACE //////////////////////////////////////////////////

            gameTitle = new Sprite("title", "Assets/Sprites/GameTitle.txt");

            ItemCollectionMenu = new Sprite("itemCollectionMenu", 
                                            "Assets/UserInterface/ItemCollection.txt"
                                            );

            ProtagonistStatistics   = new UserInterface("protagonistStatMenu", "Assets/UserInterface/protagonistStats.txt");
            BossStatistics          = new UserInterface("bossStatMenu", "Assets/UserInterface/bossStats.txt");



            // ITEMS ///////////////////////////////////////////////////////////

            BluntSword = new Item("Blunt Sword",
                                "Assets/Sprites/bluntSword.txt",
                                () => Protagonist.SetAttack(5),
                                "You weld the blunt sword - its use escapes reason"
                                );

            // STORY PROGRAMMING ///////////////////////////////////////////////

            Action OpenInventory = () =>
            {
                do
                {
                    InventoryMenu.PrintSprite(0, 0, InventoryMenu.GetWidth(), InventoryMenu.GetHeight(), Screen.CenterSpriteX(InventoryMenu), Screen.CenterSpriteY(InventoryMenu));
                } while (!IsEscapePressed());
            };

            Action ShowBattleStats = () =>
            {
                do
                {
                    ProtagonistStatistics.PrintSprite(0, 0, ProtagonistStatistics.GetWidth(), ProtagonistStatistics.GetHeight(), 1, Screen.GetHeight() - 1 - ProtagonistStatistics.GetHeight());
                    BossStatistics.PrintSprite(0, 0, BossStatistics.GetWidth(), BossStatistics.GetHeight(), Screen.GetWidth() - 1 - BossStatistics.GetHeight(), Screen.GetHeight() - 1 - BossStatistics.GetHeight());
                }
                while (StoryComponent.isBattling);
            };

            openingMonologue.AddAction("Enter Cave", () =>
            {
                Screen.PrintText("The spirit of adventure wells within you and you step boldly into the unknown.", 5, 5, 20, 20);
                Screen.PrintText("Somewhere in the depths of the cave, another is made aware of your presence...", 5, 10, 80, 100);
            });


            // start the game

            Screen.SetToConsole(); // configure the Screen buffer
            Screen.Clear();

            Console.CursorVisible   = false;

            // grab the current console colors
            originalBackgroundColor = Console.BackgroundColor;
            originalForgroundColor  = Console.ForegroundColor;

            // update the colors
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;

            // start the game and input loops
            isRunning = true;

            InputThread.Start();
            PhysicsThread.Start();

            BeginGame();
        }

        // METHODS /////////////////////////////////////////////////////////////

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

                    case ConsoleKey.Escape:
                    case ConsoleKey.E:
                    case ConsoleKey.Backspace:
                        pressedKeys["escape"] = true;
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

            int paralaxProgress = 1;

            while (paralaxProgress < forestParalax3.GetWidth() / 4 - Screen.GetWidth())
            {
                Step();
                if (gameTick % 20 == 0)
                {
                    forestParalax1.PrintSprite(
                        forestParalax1.GetWidth() - Screen.GetWidth() - paralaxProgress++,
                        0,
                        Screen.GetWidth(),
                        forestParalax1.GetHeight(),
                        0,
                        0
                    );

                    forestParalax2.PrintSprite(
                        forestParalax2.GetWidth() - Screen.GetWidth() - paralaxProgress * 2,
                        0,
                        Screen.GetWidth(),
                        forestParalax2.GetHeight(),
                        0,
                        10
                    );
  
                    forestParalax3.PrintSprite(
                        forestParalax3.GetWidth() - Screen.GetWidth() - paralaxProgress * 4,
                        0,
                        Screen.GetWidth(),
                        forestParalax3.GetHeight(),
                        0,
                        15
                    );

                    gameTitle.PrintSprite(0, 0, gameTitle.GetWidth(), gameTitle.GetHeight(), 1, 1, 0);
                }

                if (IsSelectPressed()) break;
            }

            Screen.Clear();

            Screen.PrintText("A love of adventure compelled you to lift the dusty book off the shelf", 5, 5, 20, 50);
            Screen.PrintText("You open to the first page and begin to read... but Somehow, the story begins to flow by itself", 30, 5, 20, 50);
            Screen.PrintText("Time slows, reality warps, reality becomes but a dream... the story takes the stage", 5, 15, 50, 50);

            Screen.Clear();

            Screen.PrintText("you try to resist... but there is no longer any book to put down... you a slave to the untold story", 5, 5, 60, 100);
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
        public bool IsEscapePressed()   => pressedKeys["escape"];
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
