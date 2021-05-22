using System;

namespace CAT
{
    class CatBook
    {
        //VARIABLES FOR ALL ROOMS eg- items and buffs. 
        //cheese, no bell, scratchpost, closed door
        //boolean array 0=door, 1=bell, 2=scratchpost, 3=cheese, 4=vase, more later.
        private static bool[] state = {false, false, false, false, false };
        //also variable for room currently in
        private static string currentRoom;


        //HELP TEXT
        public static void help()
        {
            Console.WriteLine("This is the helptext");
            Console.WriteLine("Cat words!");
            Console.WriteLine("GO or GO TO location - takes you to that location");
            Console.WriteLine("LOOK or LOOK AT object - gives you more information on an object");
            Console.WriteLine("USE object - uses an object");
            Console.WriteLine("DESTROY object - destroys an object");
            Console.WriteLine("EAT object - hongry kitty");
        }

        //LOUNGE
        public static void lounge()
        {
            //lounge will have one interact
            //mouse house
            currentRoom = "lounge";
            Console.WriteLine("This is lounge");
            Console.WriteLine("You hear mouse");
            if (state[1] == false)
            {
                Console.WriteLine("Mouse hears you");
            }
            whatDo();
        }


        //KITCHEN
        public static void kitchen()
        {
            //kitchen will have one interact
            //counter
            currentRoom = "kitchen";
            Console.WriteLine("This is kitchen");
            if (state[4] == false)
            {
                Console.WriteLine("There is stuff on the counter");
            }
            whatDo();
        }


        //COUNTER
        public static void counter()
        {
            //BREAK STUFF, STEAL CHEESE
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
            whatDo();
        }


        //BEDROOM
        public static void bedroom()
        {
            //lounge will have two interacts
            //scratching post and bed
            currentRoom = "bedroom";
            Console.WriteLine("This is bedroom");
            whatDo();
        }

        
        //HALLWAY
        public static void hallway()
        {
            //hallway will have one interact
            //closed door
            currentRoom = "hallway";
            Console.WriteLine("This is hallway");
            whatDo();
        }


        //CATCH THE MOUSE
        public static void mousey()
        {
            //minigame
            //will check for items/buffs and adjust difficulty
        }

        //DO A CHOOSE
        public static void whatDo()
        {
            string choice;

            Console.WriteLine("Where go?");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "GO LOUNGE":
                    //if door closed, show closed door message
                    //else go lounge
                    lounge();
                    break;
                case "GO KITCHEN":
                    kitchen();
                    break;
                case "GO COUNTER":
                    if(currentRoom == "kitchen")
                    {
                        counter();
                    }
                    else
                    {
                        Console.WriteLine("You aren't in kitchen!");
                        whatDo();
                    }
                    break;
                case "EAT CHEESE":
                    if (state[3] == false)
                    {
                        Console.WriteLine("You ate some of the cheese");
                        Console.WriteLine("You will regret this later");
                    }
                    else
                    {
                        Console.WriteLine("No cheese");
                    }
                    whatDo();
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
                    whatDo();
                    break;
                case "GO BEDROOM":
                    bedroom();
                    break;
                case "GO HALLWAY":
                    hallway();
                    break;
                case "DESTROY BELL":
                    state[1] = true;
                    Console.WriteLine("You have killed the bell");
                    whatDo();
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
                    whatDo();
                    break;
            }
        }
        static void Main(string[] args)
        {

            Console.WriteLine("OH DANG! You're a cat!");
            Console.WriteLine("Hello cat!");
            Console.WriteLine("House has lounge, kitchen, bedroom, hallway");

            whatDo();

            Console.ReadLine();

            

        }
    }
}
