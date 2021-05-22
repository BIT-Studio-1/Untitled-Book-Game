using System;

namespace CAT
{
    class CatBook
    {
        //VARIABLES FOR ALL ROOMS eg- items and buffs. 
        //cheese, no bell, scratchpost, closed door
        //boolean array 0=door, 1=bell, 2=scratchpost, 3=cheese, more later.
        private static bool[] state = {false, false, false, false };
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
            //cheese
            currentRoom = "kitchen";
            Console.WriteLine("This is kitchen");
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
