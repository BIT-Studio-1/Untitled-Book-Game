
using System;

namespace CAT
{
    class CatBook
    {
        //SWITCHES IN SWITCHES OK?
        //LETS MAKE THIS MESSY.
        //
        //VARIABLES FOR ALL ROOMS eg- items and buffs. 
        //cheese, no bell, scratchpost, closed door
        //boolean array 0=door, 1=bell, 2=scratchpost, 3=cheese, 4=vase, more later.
        private static bool[] state = {false, false, false, false, false };
        //also variable for room currently in
        private static string currentRoom, choice;


        //INPUT MAKER
        public static void input()
        {
            Console.WriteLine("Meow?");
            choice = Console.ReadLine();
            choice = choice.ToUpper();

        }

        //HELP TEXT
        public static void help()
        {
            Console.Clear();
            Console.WriteLine("This is the helptext");
            Console.WriteLine("Cat words!");
            Console.WriteLine("GO or GO TO location - takes you to that location");
            Console.WriteLine("LOOK or LOOK AT object - gives you more information on an object");
            Console.WriteLine("USE object - uses an object");
            Console.WriteLine("DESTROY object - destroys an object");
            Console.WriteLine("EAT object - hongry kitty");
            input();
            whatDo();
        }


        //MEOW
        public static void meow()
        {
            Console.WriteLine("MEOW");
            choice = Console.ReadLine();
            choice = choice.ToUpper();
            whatDo();
        }

        //BELL INDICATION
        public static void bell()
        {
            if (state[1] == false)
            {
                Console.WriteLine("The bell around your neck jingles as you move.");
                Console.WriteLine("Irritating");
                Console.ReadLine();
            }
        }

        //LOUNGE
        public static void lounge()
        {
            //lounge will have one interact
            //mouse house
            Console.Clear();
            currentRoom = "lounge";
            Console.WriteLine("This is lounge");
            Console.WriteLine("You hear mouse");
            if (state[1] == false)
            {
                Console.WriteLine("Mouse hears you");
            }
            input();
            switch (choice)
            {
                case "GO MOUSE HOUSE":
                case "GO MOUSE":
                    mousey();
                    break;
                default:
                    whatDo();
                    break;
            }
        }


        //KITCHEN
        public static void kitchen()
        {
            //kitchen will have one interact
            //counter
            Console.Clear();
            currentRoom = "kitchen";
            Console.WriteLine("This is kitchen");
            if (state[4] == false)
            {
                Console.WriteLine("There is stuff on the counter");
            }
            input();
            switch (choice)
            {
                case "GO COUNTER":
                    counter();
                    break;
                default:
                    whatDo();
                    break;
            }
        }


        //COUNTER
        public static void counter()
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
            else if(state[4] == false && state[3] == false)
            {
                Console.WriteLine("There is nothing here, how sad");
            }
            input();
            switch (choice)
            {
                case "EAT CHEESE":
                    if (state[3] == false)
                    {
                        Console.WriteLine("You ate some of the cheese");
                        Console.WriteLine("You now smell like a cheese");
                        Console.WriteLine("You will regret this later");
                        state[3] = true;
                    }
                    else
                    {
                        Console.WriteLine("No cheese");
                    }
                    counter();
                    break;
                case "DESTROY VASE":
                    if (state[4] == false)
                    {
                        Console.WriteLine("You push the vase off the counter. It shatters");
                        Console.WriteLine("Very satisfying");
                        state[4] = true;
                    }
                    else
                    {
                        Console.WriteLine("You already killed the vase");
                    }
                    counter();
                    break;
                default:
                    whatDo();
                    break;
            }
        }


        //BEDROOM
        public static void bedroom()
        {
            //lounge will have two interacts
            //scratching post and bed
            Console.Clear();
            currentRoom = "bedroom";
            Console.WriteLine("This is bedroom");
            Console.WriteLine("You see your scratching post and your bed");
            input();
            switch (choice)
            {
                case "USE SCRATCHING POST":
                    state[2] = true;
                    Console.WriteLine("Sharp kitty");
                    Console.ReadLine();
                    bedroom();
                    break;
                case "SLEEP":
                case "USE BED":
                    Console.WriteLine("Sleepy kitty, good nap");
                    Console.ReadLine();
                    bedroom();
                    break;
                default:
                    whatDo();
                    break;

            }
        }

        
        //HALLWAY
        public static void hallway()
        {
            //hallway will have one interact
            //closed door
            Console.Clear();
            currentRoom = "hallway";
            Console.WriteLine("This is hallway");
            if (state[0] == false)
            {
                Console.WriteLine("Lounge door is closed");
            }
            input();
            switch (choice)
            {
                case "OPEN DOOR":
                    Console.WriteLine("Door open now. Strong kitty");
                    Console.ReadLine();
                    state[0] = true;
                    hallway();
                    break;
                default:
                    whatDo();
                    break;
            }
        }


        //CATCH THE MOUSE
        public static void mousey()
        {
            Console.Clear();
            currentRoom = "mousey";
            Console.WriteLine("It's the mouse");
            Console.WriteLine("It must be destroyed");
            input();
            switch (choice)
            {
                case "DESTROY MOUSE":
                case "ATTACK MOUSE":
                    //check for buffs
                    if (state[3] == false)
                    {
                        Console.WriteLine("Mousey smells you coming, he hides");
                        Console.WriteLine("Coward");
                        lounge();
                    }
                    else if (state[2] == false)
                    {
                        Console.WriteLine("You pounce on mouse");
                        Console.WriteLine("You are not sharp enough, mousey escapes");
                        Console.WriteLine("Lucky.");
                        lounge();
                    }
                    else if (state[2] == true && state[3] == true)
                    {
                        Console.WriteLine("You catch the mouse");
                        Console.WriteLine("Vae Victis");
                        Console.WriteLine("END OF CAT GAME");
                        Console.ReadLine();
                    }
                    break;
                default:
                    whatDo();
                    break;
            }

        }

        //TELLS YOU WHAT ROOM IT IS
        public static void roomReset()
        {
            switch (currentRoom)
            {
                case "lounge":
                    lounge();
                    break;
                case "kitchen":
                    kitchen();
                    break;
                case "counter":
                    counter();
                    break;
                case "bedroom":
                    bedroom();
                    break;
                case "hallway":
                    hallway();
                    break;
                case "mousey":
                    mousey();
                    break;
                default:
                    whatDo();
                    break;

            }
        }

        //DO A CHOOSE
        public static void whatDo()
        {

            switch (choice)
            {
                case "GO LOUNGE":
                    //if door closed, show closed door message
                    //else go lounge
                    if (state[0] == false)
                    {
                        Console.WriteLine("Door is closed");
                        choice = Console.ReadLine();
                        hallway();
                    }
                    else
                    {
                        bell();
                        lounge();
                    }
                    break;
                case "GO KITCHEN":
                    bell();
                    kitchen();
                    break;
                case "GO BEDROOM":
                    bell();
                    bedroom();
                    break;
                case "GO HALLWAY":
                    bell();
                    hallway();
                    break;
                case "DESTROY BELL":
                    state[1] = true;
                    Console.WriteLine("You have killed the bell");
                    roomReset();
                    break;
                case "MEOW":
                case "MEOW!":
                case "MEOW.":
                case "MEOWMEOW":
                    meow();
                    break;
                case "EXIT":
                    Console.WriteLine("Okaybye!");
                    Console.ReadLine();
                    break;
                case "HELP":
                    help();
                    break;
                default:
                    Console.WriteLine("Those aren't cat-approved words");
                    Console.WriteLine("Please try better");
                    Console.ReadLine();
                    roomReset();
                    break;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("OH DANG! You're a cat!");
            Console.WriteLine("Hello cat!");
            Console.WriteLine("House has lounge, kitchen, bedroom, hallway");
            Console.ReadLine();

            bedroom();


            

        }
    }
}
