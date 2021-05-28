using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace UntitledBookGame
{
    public class Global
    {
        public static List<string> inventory = new List<string>();
    }
    public partial class Program
    {
        public static void RunHorrorGame()
        {
            Console.CursorVisible = false;
            Car();
            // put your games entry code here
        }

        public static string UserInPut;
        public static void Car()
        {
            
            //------------------------------
            //This just writes out the text one letter at a time \\
            var myString = "11:26 PM."
                + Environment.NewLine + "7c and raining."
                + Environment.NewLine + "Your car has broken down in the country side of New York."
                + Environment.NewLine + "What do you want to do?"
                + Environment.NewLine;
                

            foreach (var character in myString)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }


            Console.WriteLine();
            UserInPut = Console.ReadLine();





            string Boot = "open boot", GloveBox = "open glove box", UnderSeat = " look under seat";


            if (Boot.Contains(UserInPut))
            {

                BootMethod();
            }
            else if (GloveBox.Contains(UserInPut))
            {

                GloveBoxMethod();
            }
            else if (UnderSeat.Contains(UserInPut))
            {

                UnderSeatMethod();
            }
            else
            {
                var DidNotUnderStand = "I Do Not UnderStand."
                + Environment.NewLine + "Make Sure That You Are Not Using Capitals.";



                foreach (var character in DidNotUnderStand)
                {
                    Console.Write(character);
                    Thread.Sleep(30);
                }
                Thread.Sleep(3000);

                Start();

            }






            Console.ReadLine();
        }

        //This is The Diffrent 'Rooms' With in the car
        public static void BootMethod()
        {
            Console.Clear();
            Console.Clear();
            var UnderSeat = "You Are in In The Boot." +
                Environment.NewLine + "There are items in the boot."+
                Environment.NewLine + "Tourch" +
                Environment.NewLine + "Tire Iron" +
                Environment.NewLine + "Rope" +
                Environment.NewLine + "Axe With Blood on it?"
                + Environment.NewLine;


            foreach (var character in UnderSeat)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }

        }

        public static void GloveBoxMethod()
        {
            Console.Clear();
            Console.Clear();
            var UnderSeat = "You Are in In The GloveBox." +
                Environment.NewLine + "There are items in the Glovebox" +
                Environment.NewLine + "First Aid Kit" +
                Environment.NewLine + "Cars Manual" +
                Environment.NewLine + "Random Key"
                + Environment.NewLine;


            foreach (var character in UnderSeat)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }
        }

        public static void UnderSeatMethod()
        {
            Console.Clear();
            var UnderSeat = "You Are Under The Seat."+
                Environment.NewLine + "There are items under the seat"+
                Environment.NewLine + "Lint";


            foreach (var character in UnderSeat)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }

        }

        public static void Items()
        {

        }

        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("You are still in the car.");

            string UserInPut;

            UserInPut = Console.ReadLine();

            string Boot = "open boot", GloveBox = "open glove box", UnderSeat = " look under seat";


            if (Boot.Contains(UserInPut))
            {

                BootMethod();
            }
            else if (GloveBox.Contains(UserInPut))
            {

                GloveBoxMethod();
            }
            else if (UnderSeat.Contains(UserInPut))
            {

                UnderSeatMethod();
            }
            else
            {

                var DidNotUnderStand = "I Do Not UnderStand."
                + Environment.NewLine + "Make Sure That You Are Not Using Capitals.";



                foreach (var character in DidNotUnderStand)
                {
                    Console.Write(character);
                    Thread.Sleep(30);
                }

                Thread.Sleep(3000);

                Start();



            }

            
        }

        public static void ItemsInInvin()
        {
            
        }
        public static void items()
        {
            if (UserInPut.Contains("First aid kit"))
            {
                Global.inventory.Add("First aid kit");
            }
        }

    }
}




        // other game code, methods, etc.






