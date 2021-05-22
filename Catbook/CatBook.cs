using System;

namespace CAT
{
    class CatBook
    {
        //VARIABLES FOR ALL ROOMS eg- items and buffs. 
        //cheese, no bell, scratchpost


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
            Console.WriteLine("This is lounge");
            whatDo();
        }


        //KITCHEN
        public static void kitchen()
        {
            //kitchen will have one interact
            //cheese
            Console.WriteLine("This is kitchen");
            whatDo();
        }


        //BEDROOM
        public static void bedroom()
        {
            //lounge will have two interacts
            //scratching post and bed
            Console.WriteLine("This is bedroom");
            whatDo();
        }

        
        //HALLWAY
        public static void hallway()
        {
            //hallway will have no interacts
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
