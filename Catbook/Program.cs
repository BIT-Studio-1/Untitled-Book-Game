using System;

namespace CAT
{
    class Program
    {
        //VARIABLES FOR ALL ROOMS   


        //LIVING ROOM
        public static void lounge()
        {
            Console.WriteLine("This is lounge");
            whatDo();
        }


        //KITCHEN
        public static void kitchen()
        {
            Console.WriteLine("This is kitchen");
            whatDo();
        }


        //BEDROOM
        public static void bedroom()
        {
            Console.WriteLine("This is bedroom");
            whatDo();
        }

        
        //HALLWAY
        public static void hallway()
        {
            Console.WriteLine("This is hallway");
            whatDo();
        }


        //CATCH THE MOUSE


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
