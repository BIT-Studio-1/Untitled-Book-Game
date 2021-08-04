using System;

namespace UntitledBookGame
{
    public partial class Program
    {
        public static void RunCatGame()
        {
            //initial message
            Book();
                Console.WriteLine("OH DANG! You're a cat!");
                Console.WriteLine("Hello cat!");
                Console.WriteLine("House has lounge, kitchen, bedroom, hallway");
                Console.ReadLine();

                Bedroom();
        }

        
            //SWITCHES IN SWITCHES OK?
            //LETS MAKE THIS MESSY.
            //
            //VARIABLES FOR ALL ROOMS eg- items and buffs. 
            //cheese, no bell, scratchpost, closed door
            //boolean array 0=door, 1=bell, 2=scratchpost, 3=cheese, 4=vase, more later.
            private static bool[] state = { false, false, false, false, false };
            //also variable for room currently in
            private static string currentRoom, choice;


            //BOOK LOOK
        public static void Book()
        {
            Console.WriteLine(" ============================================================");
            Console.WriteLine(" ============================================================");
            Console.WriteLine(" ||                                                         ||");
            Console.WriteLine(" ||             ..                       ..                 ||");
            Console.WriteLine(" ||            //\\\\                     // \\\\               ||");
            Console.WriteLine(" ||           //  \\\\                   //   \\\\              ||");
            Console.WriteLine(" ||          //    \\\\                 //     \\\\             ||");
            Console.WriteLine(" ||         //   www\\\\oooo'''''''oooo//www    \\\\            ||");
            Console.WriteLine(" ||        oo                                  oo           ||");
            Console.WriteLine(" ||       oo                                    oo          ||");
            Console.WriteLine(" ||       oo           \\             /          oo          ||");
            Console.WriteLine(" ||      oo                                      oo         ||");
            Console.WriteLine(" ||      oo          !?               ?!         oo         ||");
            Console.WriteLine(" ||       oo                ___                 oo          ||");
            Console.WriteLine(" ||        oo               \\_/               oo            ||");
            Console.WriteLine(" ||          oo              |                oo            ||");
            Console.WriteLine(" ||            ooo        ._/ \\_.          ooo              ||");
            Console.WriteLine(" ||               ooo                   ooo                 ||");
            Console.WriteLine(" ||                  [][][][][][][][][]                     ||");
            Console.WriteLine(" ||                       { >()< }                          ||");
            Console.WriteLine(" ||                         //\\\\                            ||");
            Console.WriteLine(" ||                                                         ||");
            Console.WriteLine(" ||           oooo            ooo         oooooooooo        ||");
            Console.WriteLine(" ||          OOOOOOOo        OOOOO       OOOOOOOOOOOO       ||");
            Console.WriteLine(" ||         OO    OOoo      OO   OO           OO            ||");
            Console.WriteLine(" ||        OO              OO     OO          OO            ||");
            Console.WriteLine(" ||        OO             OO ooooo OO         OO            ||");
            Console.WriteLine(" ||         OO    OOo    OO         OO        OO            ||");
            Console.WriteLine(" ||          OOOOOOo    OO           OO       OO            ||");
            Console.WriteLine(" ||                                                         ||");
            Console.WriteLine(" ||                                                         ||");
            Console.WriteLine(" ||                                                         ||");
            Console.WriteLine(" =============================================================");
            Console.WriteLine(" =============================================================");
            Console.ReadLine();
        }    
        
        //INPUT MAKER
            public static void Input()
            {
                Console.WriteLine("Meow?");
                choice = Console.ReadLine();
                choice = choice.ToUpper();

            }

            //HELP TEXT
            public static void Help()
            {
                Console.Clear();
                Console.WriteLine("This is the helptext");
                Console.WriteLine("Cat words!");
                Console.WriteLine("GO or GO TO location - takes you to that location");
                //Console.WriteLine("LOOK or LOOK AT object - gives you more information on an object");
                Console.WriteLine("USE object - uses an object");
                Console.WriteLine("DESTROY object - destroys an object");
                Console.WriteLine("EAT object - hongry kitty");
                Input();
                WhatDo();
            }


            //MEOW
            public static void Meow()
            {
                Console.WriteLine("MEOW");
                choice = Console.ReadLine();
                choice = choice.ToUpper();
                WhatDo();
            }

            //BELL INDICATION
            public static void Bell()
            {
                if (state[1] == false)
                {
                    Console.WriteLine("The bell around your neck jingles as you move.");
                    Console.WriteLine("Irritating");
                    Console.ReadLine();
                }
            }

            //LOUNGE
            public static void Lounge()
            {
                //lounge will have one interact
                //mouse house
                Console.Clear();
                currentRoom = "lounge";
                Console.WriteLine("This is lounge");
                Console.WriteLine("The door leads to hallway");
                Console.WriteLine("You hear mouse");
                if (state[1] == false)
                {
                    Console.WriteLine("Mouse hears you");
                }
                Input();
                switch (choice)
                {
                    case "GO MOUSE HOUSE":
                    case "GO MOUSE":
                    case "GO TO MOUSE":
                    case "GO TO MOUSE HOUSE":
                        Mousey();
                        break;
                    default:
                        WhatDo();
                        break;
                }
            }


            //KITCHEN
            public static void Kitchen()
            {
                //kitchen will have one interact
                //counter
                Console.Clear();
                currentRoom = "kitchen";
                Console.WriteLine("This is kitchen");
                Console.WriteLine("The door leads to hallway");
                if (state[4] == false)
                {
                    Console.WriteLine("There is stuff on the counter");
                }
                Input();
                switch (choice)
                {
                    case "GO COUNTER":
                    case "GO TO COUNTER":
                        Counter();
                        break;
                    default:
                        WhatDo();
                        break;
                }
            }


            //COUNTER
            public static void Counter()
            {
                //BREAK STUFF, STEAL CHEESE
                Console.Clear();
                currentRoom = "counter";
                Console.WriteLine("Welcome to counter!");
                Console.WriteLine("You aren't supposed to be up here");
                if (state[4] == false)
                {
                    Console.WriteLine("There is a nice vase up here");
                }
                if (state[3] == false)
                {
                    Console.WriteLine("You see cheese");
                }
                else if (state[4] == false && state[3] == false)
                {
                    Console.WriteLine("There is nothing here, how sad");
                }
                Input();
                switch (choice)
                {
                    case "EAT CHEESE":
                        if (state[3] == false)
                        {
                            Console.WriteLine("You ate some of the cheese");
                            Console.WriteLine("You now smell like a cheese");
                            Console.WriteLine("You will regret this later");
                            Console.ReadLine();
                            state[3] = true;
                        }
                        else
                        {
                            Console.WriteLine("No cheese");
                            Console.ReadLine();
                        }
                        Counter();
                        break;
                    case "DESTROY VASE":
                        if (state[4] == false)
                        {
                            Console.WriteLine("You push the vase off the counter. It shatters");
                            Console.WriteLine("Very satisfying");
                            Console.ReadLine();
                            state[4] = true;
                        }
                        else
                        {
                            Console.WriteLine("You already killed the vase");
                            Console.ReadLine();
                        }
                        Counter();
                        break;
                    default:
                        WhatDo();
                        break;
                }
            }


            //BEDROOM
            public static void Bedroom()
            {
                //lounge will have two interacts
                //scratching post and bed
                Console.Clear();
                currentRoom = "bedroom";
                Console.WriteLine("This is bedroom");
                Console.WriteLine("The door leads to hallway");
                Console.WriteLine("You see your scratching post and your bed");
                Input();
                switch (choice)
                {
                    case "USE SCRATCHING POST":
                    case "SCRATCH":
                        state[2] = true;
                        Console.WriteLine("Sharp kitty");
                        Console.ReadLine();
                        Bedroom();
                        break;
                    case "SLEEP":
                    case "USE BED":
                        Console.WriteLine("Sleepy kitty, good nap");
                        Console.ReadLine();
                        Bedroom();
                        break;
                    default:
                        WhatDo();
                        break;

                }
            }


            //HALLWAY
            public static void Hallway()
            {
                //hallway will have one interact
                //closed door
                Console.Clear();
                currentRoom = "hallway";
                Console.WriteLine("This is hallway");
                Console.WriteLine("There are three doors.");
                Console.WriteLine("They lead to bedroom, kitchen and lounge");
                if (state[0] == false)
                {
                    Console.WriteLine("Lounge door is closed");
                }
                Input();
                switch (choice)
                {
                    case "OPEN DOOR":
                        Console.WriteLine("Door open now. Strong kitty");
                        Console.ReadLine();
                        state[0] = true;
                        Hallway();
                        break;
                    default:
                        WhatDo();
                        break;
                }
            }


            //CATCH THE MOUSE
            public static void Mousey()
            {
                Console.Clear();
                currentRoom = "mousey";
            if(state[1] == true)
            {
                Console.WriteLine("It's the mouse");
                Console.WriteLine("It must be destroyed");
                Input();
                switch (choice)
                {
                    case "DESTROY MOUSE":
                    case "ATTACK MOUSE":
                        //check for buffs
                        if (state[2] == true && state[3] == true)
                        {
                            Console.WriteLine("You catch the mouse");
                            Console.WriteLine("Vae Victis");
                            Console.WriteLine("END OF CAT GAME");
                            Console.ReadLine();
                        }
                        else if (state[2] == false)
                        {
                            Console.WriteLine("You pounce on mouse");
                            Console.WriteLine("You are not sharp enough, mousey escapes");
                            Console.WriteLine("Lucky.");
                            Console.ReadLine();
                            Lounge();
                        }
                        else if (state[3] == false)
                        {
                            Console.WriteLine("Mousey smells you coming, he hides");
                            Console.WriteLine("Coward");
                            Console.ReadLine();
                            Lounge();
                        }
                        break;
                    default:
                        WhatDo();
                        break;

                }
            }
            else
            {
                Console.WriteLine("You are not very sneaky");
                Console.WriteLine("Mouse is hiding");
                Input();
                WhatDo();
            }               
            }

            //TELLS YOU WHAT ROOM IT IS
            public static void RoomReset()
            {
                switch (currentRoom)
                {
                    case "lounge":
                        Lounge();
                        break;
                    case "kitchen":
                        Kitchen();
                        break;
                    case "counter":
                        Counter();
                        break;
                    case "bedroom":
                        Bedroom();
                        break;
                    case "hallway":
                        Hallway();
                        break;
                    case "mousey":
                        Mousey();
                        break;
                    default:
                        WhatDo();
                        break;

                }
            }

            //DO A CHOOSE
            public static void WhatDo()
            {

                switch (choice)
                {
                    case "GO LOUNGE":
                    case "GO TO LOUNGE":
                        //if door closed, show closed door message
                        //else go lounge
                        if (state[0] == false)
                        {
                            Console.WriteLine("Door is closed");
                            choice = Console.ReadLine();
                            Hallway();
                        }
                        else
                        {
                            Bell();
                            Lounge();
                        }
                        break;
                    case "GO KITCHEN":
                    case "GO TO KITCHEN":
                        Bell();
                        Kitchen();
                        break;
                    case "GO BEDROOM":
                    case "GO TO BEDROOM":
                        Bell();
                        Bedroom();
                        break;
                    case "GO HALLWAY":
                    case "GO TO HALLWAY":
                        Bell();
                        Hallway();
                        break;
                    case "DESTROY BELL":
                        state[1] = true;
                        Console.WriteLine("You have killed the bell");
                        Console.ReadLine();
                        RoomReset();
                        break;
                    case "MEOW":
                    case "MEOW!":
                    case "MEOW.":
                    case "MEOWMEOW":
                        Meow();
                        break;
                    case "EXIT":
                        Console.WriteLine("Okaybye!");
                        Console.ReadLine();
                        break;
                    case "HELP":
                        Help();
                        break;
                    default:
                        Console.WriteLine("Those aren't cat-approved words");
                        Console.WriteLine("Please try better");
                        Console.ReadLine();
                        RoomReset();
                        break;
                }
            }
            
        }
    }





    // other game code, methods, etc.

