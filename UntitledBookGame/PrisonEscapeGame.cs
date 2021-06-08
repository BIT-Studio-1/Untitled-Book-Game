using System;
using System.Threading;

namespace UntitledBookGame
{
    public partial class Program
    {
        static void instructions()
        {
            Console.Clear();
            Console.WriteLine("type keys 'W' to move forward, 'D' to move right, 'A' to move left, 'S' to move back");
            Console.WriteLine("'I' is used to acces your inventory, this tell you what you are currently holding");
            Console.WriteLine("A description of your surroundings is given when you enter a new room");
            Console.WriteLine("");
            Console.WriteLine("Press enter to begin...");
            Console.ReadLine();

        }
        static void RunPrisonEscapeGame()
        {
            string[] inventory = new string[3];
            inventory[1] = "Screwdriver";
            inventory[2] = "Sock";
            string temp, takeItems, pryOpen;

            Console.WriteLine("Welcome to Prison Escape!".PadLeft(60));
            Console.WriteLine();
            Console.WriteLine("Created by Kanen Scheib");
            Console.WriteLine("About: Prison Escape gives players an insight into the life of a prison inmate with the main objective being of course");
            Console.WriteLine("escaping!");
            Console.WriteLine("type 'A' to begin...");
            Console.WriteLine("Or type 'I' for Instructions");
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

            do
            {
                switch (temp)
                {
                    case "i":
                        instructions();
                        break;

                    case "a":
                        Console.Clear();
                        Console.WriteLine("You have somehow got yourself in prison...the time has come to put the greatest escape plan to the test!");
                        Console.WriteLine("How you do this is completely upto you...");
                        Console.WriteLine("You must investigate clues and pick up items along the way to help you engineer your escape by any means necessary");
                        Console.WriteLine("");
                        Console.WriteLine("Press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("You are sitting upright in your bed facing the prison cell wall");
                        Console.WriteLine("to the left is a close-coupled porcelain toilet");
                        Console.WriteLine("To the right is a rectangle stanless detention desk with swivel stool");
                        Console.WriteLine("above you is a vent that looks just big enough to fit through");
                        break;
                }

            } while (temp == "i");
            do
            {
                Console.WriteLine("");
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
                        Console.WriteLine("Press 'I' to take items");
                        Console.WriteLine("Press enter to continue...");
                        takeItems = Console.ReadLine();
                        if (takeItems == "i")
                        {
                            Console.WriteLine("");
                            Console.WriteLine(inventory[1] + " and a " + inventory[2] + " have been added to your inventory!");
                        }
                        else
                        {
                            PrisonCell();
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
                        Console.WriteLine("just a wall, nothing special here");
                        Console.WriteLine("");
                        break;

                    case "i":
                        Console.Clear();
                        Console.WriteLine("Nothing in inventory");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Nowhere to go");
                        break;

                }
            } while ((temp == "s") || (temp == "w") || (temp == "i") || (temp == "a"));

            do
            {
                Console.WriteLine("");
                Console.WriteLine("where to next?");
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
                        Console.WriteLine("You can equip that screwdriver you found to pry it open");
                        Console.WriteLine("Press 'o' to pry vent open with screwdriver");
                        pryOpen = Console.ReadLine();
                        if (pryOpen == "o")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("open seasame!");
                            Console.WriteLine("new location unlocked! you can now access the ceiling vent");
                        }
                        else
                        {
                            CellItemsRemoved();
                        }

                        break;

                    case "i":
                        Console.Clear();
                        Console.WriteLine("You currently have a" + inventory[1] + " and a " + inventory[2]);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Nowhere to go");
                        CellItemsRemoved();
                        break;

                }
            } while ((temp == "w") || (temp == "d") || (temp == "a") || (temp == "i"));

            Console.ReadLine();
        }
        static void PrisonCell()
        {

            string[] inventory = new string[3];
            inventory[1] = "Screwdriver";
            inventory[2] = "Sock";
            string temp, takeItems;


            do
            {
                Console.WriteLine("");
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
                        Console.WriteLine("Press 'I' to take items");
                        Console.WriteLine("");
                        takeItems = Console.ReadLine();
                        if (takeItems == "i")
                        {
                            Console.WriteLine("");
                            Console.WriteLine(inventory[1] + " and a " + inventory[2] + " have been added to your inventory!");
                        }
                        else
                        {
                            PrisonCell();
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
                        Console.WriteLine("just a wall, nothing special here");
                        Console.WriteLine("");
                        break;

                    case "i":
                        Console.Clear();
                        Console.WriteLine("Nothing in inventory");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Nowhere to go");
                        break;

                }
            } while ((temp == "s") || (temp == "w") || (temp == "i") || (temp == "a"));
        }


        static void CellItemsRemoved()
        {
            string[] inventory = new string[3];
            inventory[1] = "Screwdriver";
            inventory[2] = "Sock";
            string temp, pryOpen;

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
                        Console.WriteLine("You can equip that screwdriver you found to pry it open");
                        Console.WriteLine("Press 'o' to pry vent open with screwdriver");
                        pryOpen = Console.ReadLine();
                        if (pryOpen == "o")
                        {
                            Console.WriteLine("");
                            Console.WriteLine("open seasame!");
                            Console.WriteLine("new location unlocked! you can now access the ceiling vent");
                        }
                        else
                        {
                            CellItemsRemoved();
                        }
                        break;

                    case "i":
                        Console.Clear();
                        Console.WriteLine("You currently have a" + inventory[1] + " and a " + inventory[2]);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Nowhere to go");
                        CellItemsRemoved();
                        break;

                }
            } while ((temp == "s") || (temp == "w") || (temp == "i") || (temp == "a"));
        }
    }
}






  
