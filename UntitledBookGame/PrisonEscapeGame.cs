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
                instructions(); //Instruction method is called here when user enters "i"
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

            FirstRoomPrisonCell(); //First room method is called

        }

        static void FirstRoomPrisonCell() //Starting room
        {
            do
            {
                Console.WriteLine("Where to next?");
                Console.WriteLine("press 'i' for inventory");
                Console.Write("");
                Console.Write(">");
                temp = Console.ReadLine();


                switch (temp)
                {
                    case "a":
                        Console.Clear();
                        Console.WriteLine("Nothing to salavge from the toilet...gross");
                        Console.WriteLine("");
                        Console.Write(">");
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("You open one of the drawers of the desk to find one of the maintence workers left a screwdriver and a sock");
                        Console.WriteLine("Press 'i' to take items");
                        Console.Write("");
                        Console.Write(">");
                        takeItems = Console.ReadLine();
                        if (takeItems == "i")
                        {
                            inventory[0] = "screwdriver";
                            inventory[1] = "sock";
                            Console.WriteLine("");
                            Console.WriteLine(inventory[0] + " and a " + inventory[1] + " have been added to your inventory!");
                            FirstRoomPrisonCellStage2();
                        }
                        else
                        {
                            FirstRoomPrisonCell(); //reverts back to the start if items are not collected
                        }
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine("You stand on top of the bed, that vent looks to be in reach now");
                        Console.WriteLine("You will need to pry it open with something");
                        Console.WriteLine("");
                        Console.Write(">");
                        break;

                    case "w":
                        Console.Clear();
                        Console.WriteLine("Just a wall, nothing special here");
                        Console.WriteLine("");
                        Console.Write(">");
                        break;

                    case "i":
                        Console.Clear();
                        if ((inventory[0] != "screwdriver") && (inventory[1] != "sock"))
                        {
                            Console.WriteLine("Nothing in inventory");
                            FirstRoomPrisonCell();
                        }
                        else
                        {
                            foreach (string s in inventory)
                            {
                                Console.WriteLine(s);
                            }
                            FirstRoomPrisonCell(); //after invenotry is displayed to the screen, reverts back to strart of the method
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input, enter directional keys 'WASD' to move");
                        FirstRoomPrisonCell();
                        break;

                }
            } while ((temp == "s") || (temp == "w") || (temp == "i") || (temp == "a"));
        }

        static void FirstRoomPrisonCellStage2() //initiating stage 2 of the changes made in room 1 where items have been added to inventory 
        {
            do
            {
                Console.WriteLine("Where to next?");
                Console.WriteLine("Press 'i' for inventory");
                Console.WriteLine("");
                Console.Write(">");
                temp = Console.ReadLine();

                switch (temp)
                {
                    case "w":
                        Console.Clear();
                        Console.WriteLine("Desk top is empty");
                        Console.WriteLine("");
                        Console.Write(">");
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("not much use being behind these prison bars...I gotta find a way out");
                        Console.WriteLine("");
                        Console.Write(">");
                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("Nothing to salavge from the toilet...gross");
                        Console.WriteLine("");
                        Console.Write(">");
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine("You stand on top of the bed, that vent looks to be in reach now");
                        Console.WriteLine("You need to pry it open with something");
                        if (inventory[0] == "screwdriver")
                        {
                            Console.WriteLine("Press 'o' to pry vent open with screwdriver");
                            Console.WriteLine("");
                            Console.Write(">");
                            pryOpen = Console.ReadLine();

                        }if (pryOpen == "o")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("open seasame!");
                            Console.WriteLine("new location unlocked! you can now access the ceiling vent");
                            ceiling(); //after vent has been opened the next room is called in method ceiling
                        }                        
                        if (inventory[0] != "screwdriver")
                        {
                            Console.WriteLine("You need additional items to progress further");
                            Console.WriteLine("");
                            FirstRoomPrisonCell(); //first room is called in method FirstRoomPrisonCell if the screwdriver has not been added to inventory

                        }
                        break;

                    case "i":
                        Console.Clear();
                        if ((inventory[0] != "screwdriver") && (inventory[1] != "sock"))
                        {
                            Console.WriteLine("Nothing in inventory");
                            FirstRoomPrisonCellStage2();
                        }
                        else
                        {
                            foreach (string s in inventory) //iterates through inventory and displays items to the screen
                            {
                                Console.WriteLine(s);
                            }
                            FirstRoomPrisonCellStage2(); //reverts back to the top of the method
                        }
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input, enter directional keys 'WASD' to move");
                        FirstRoomPrisonCellStage2(); //reverts back to the top of the method if user input is invalid
                        break;

                }
            } while ((temp == "w") || (temp == "d") || (temp == "a") || (temp == "i"));
        }

        static void ceiling() //Initiating room 3
        {
            do
            {
                Console.WriteLine("Where to next?");
                Console.WriteLine("Press 'q' to go back to previous location");
                Console.WriteLine("");
                Console.Write(">");
                temp = Console.ReadLine();

                switch (temp)
                {
                    case "w":
                        Console.Clear();
                        Console.WriteLine("I hear the guards nearby,  let's try another way");
                        Console.Write(">");
                        break;

                    case "d":
                        Console.Clear();
                        Console.WriteLine("Dead end...going back");
                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("You climb your way through the ceiling...this feels like a right way to go");
                        break;

                    case "s":
                        Console.Clear();
                        Console.WriteLine("I can see a light at the end of the vent...hopefully this leads closer to a way out");
                        break;

                    case "q":
                        Console.Clear();
                        Console.WriteLine("You are now back in the prison cell");
                        Console.WriteLine("");
                        FirstRoomPrisonCellStage2(); //calling previous room method
                        break;

                    case "i":
                        Console.Clear();
                            foreach (string s in inventory)
                            {
                                Console.WriteLine(s);
                                ceiling();
                            }
                        break;

                        default:
                        Console.Clear();
                        Console.WriteLine("Invalid Input, enter directional keys 'WASD' to move");
                        ceiling(); //back to the top of the method if invalid input is entered by user
                        break;
                }

            } while ((temp == "w") || (temp == "d") || (temp == "s"));
            Console.ReadLine();
        }
    }
}






  
