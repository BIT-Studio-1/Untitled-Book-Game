using System;
using System.Threading;

namespace UntitledBookGame
{
    public partial class Program
    {
        static string takeItems, pryOpen;
        static string[] inventory = new string[10];
        static void instructions() //How to play method
        {
            Console.Clear();
            Console.WriteLine("Type keys 'W' to move forward, 'D' to move right, 'A' to move left, 'S' to move back");
            Console.WriteLine("'I' is used to access your inventory, this notifies you of what you have currently equipped");
            Console.WriteLine("A description of your surroundings is given when you enter a new room");
            Console.WriteLine("");
            Console.WriteLine("Press enter to begin...");
            Console.ReadLine();
            RunPrisonEscapeGame();

        }

        static void LoadingScreen() //Loading screen animation
        {
            for (int load = 1; load <= 3; load++) 
            {
                Console.Clear();
                Console.WriteLine("Loading |");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Loading /");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine("Loading -");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(@"Loading \");
                Thread.Sleep(300);

                Console.Clear();

            }
        }
        static void RunPrisonEscapeGame() //Main menu screen method
        {
            string temp;

            Console.WriteLine("Welcome to Prison Escape!".PadLeft(60));
            Console.WriteLine();
            Console.WriteLine("Developed by Kanen Scheib");
            Console.WriteLine("About: Prison Escape gives players an insight into the life of a prison inmate with the main objective being of course");
            Console.WriteLine("escaping!");
            Console.WriteLine("Type 'enter' to begin...");
            Console.WriteLine("Type 'i' for Instructions");
            Console.WriteLine("__________________________________");
            Console.WriteLine("     ||      ||      ||      ||");
            Console.WriteLine("     ||      ||, , , ||      ||");
            Console.WriteLine(@"     ||     (||/|/( \||/     ||");
            Console.WriteLine("     ||     ||| _ ' _|||     ||");
            Console.WriteLine("     ||      || o  o ||      ||");
            Console.WriteLine("     ||     (||   - `||)     ||");
            Console.WriteLine("     ||      ||   =  ||      ||");
            Console.WriteLine(@"     ||      ||\____/||      ||");
            Console.WriteLine("     ||______||)  , (||______||");
            Console.WriteLine(@"    /||------|| -\_/-||------||\");
            Console.WriteLine(@"   / ||----__||______||__----||  \");
            Console.WriteLine("  (_(||)----|  S123-45   |--(||)___)");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            temp = Console.ReadLine();

            if (temp == "i")
            {
                instructions();
            }
            
             
            Console.Clear();
            Console.WriteLine("You have somehow got yourself in prison...the time has come to put the greatest escape plan to the test!");
            Console.WriteLine("How you do this is completely upto you...");
            Console.WriteLine("You must investigate clues and pick up items along the way to help you engineer your escape by any means necessary");
            Console.WriteLine("");
            Console.WriteLine("You are sitting upright in your bed facing the prison cell wall");
            Console.WriteLine("To the left is a close-coupled porcelain toilet");
            Console.WriteLine("To the right is a rectangle stanless detention desk with swivel stool");
            Console.WriteLine("");

            FirstRoomPrisonCell();

        }

        static void FirstRoomPrisonCell()
        {
            do
            {
                Console.WriteLine("Where to next?");
                temp = Console.ReadLine();


                switch (temp)
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Nothing to salavge from the toilet...gross");
                        Console.WriteLine("");
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("You find a screwdriver and a sock laying on the desk");
                        Console.WriteLine("Press 'i' to take items");
                        takeItems = Console.ReadLine();
                        if (takeItems == "i")
                        {
                            inventory[0] = "screwdriver";
                            inventory[1] = "sock";
                            Console.WriteLine("");
                            Console.WriteLine(inventory[0] + " and a " + inventory[1] + " have been added to your inventory!");
                            Console.ReadLine();
                            FirstRoomPrisonCellStage2();

                        }
                        else
                        {
                            FirstRoomPrisonCellStage2();
                        }
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine("You stand on top of the bed, that vent looks to be in reach now");
                        Console.WriteLine("You will need to pry it open with something");
                        Console.WriteLine("");
                        break;

                    case "w":
                        Console.Clear();
                        Console.WriteLine("Just a wall, nothing special here");
                        Console.WriteLine("");
                        break;

                    case "i":
                        Console.Clear();
                        Console.WriteLine("Nothing in inventory");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input, enter directional keys 'WASD' to move");
                        FirstRoomPrisonCell();
                        break;

                }
            } while ((temp == "s") || (temp == "w") || (temp == "i") || (temp == "a"));
        }

        static void FirstRoomPrisonCellStage2()
        {
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Where to next?");
                temp = Console.ReadLine();

                switch (temp)
                {
                    case "w":
                        Console.Clear();
                        Console.WriteLine("Desk top is empty");
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("not much use being behind these prison bars...I gotta find a way out");
                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("Nothing to salavge from the toilet...gross");
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine("You stand on top of the bed, that vent looks to be in reach now");
                        Console.WriteLine("You need to pry it open with something");
                        if (inventory[0] == "screwdriver")
                        {
                            Console.WriteLine("Press 'o' to pry vent open with screwdriver");
                            pryOpen = Console.ReadLine();

                        }if (pryOpen == "o")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("open seasame!");
                            Console.WriteLine("new location unlocked! you can now access the ceiling vent");
                            //Pull ceiling method here:
                        }                        
                        else
                        {
                            Console.WriteLine("You need additional items to progress further");
                            Console.WriteLine("");
                            FirstRoomPrisonCell();

                        }
                        break;

                    case "i":
                        Console.Clear();
                        Console.WriteLine("You currently have a" + inventory[1] + " and a " + inventory[2]);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Nowhere to go");
                        FirstRoomPrisonCellStage2();
                        break;

                }
            } while ((temp == "w") || (temp == "d") || (temp == "a") || (temp == "i"));

            Console.ReadLine();
        }
    }
}






  
