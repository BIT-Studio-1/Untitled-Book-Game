using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace Horror_Book
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Car();
        }

        public static void Car()

        {
            Console.Clear();

            string UserInPut;
            //------------------------------
            //This just writes out the text one letter at a time \\
            var myString = "11:26 PM."
                + Environment.NewLine + "7c and raining."
                + Environment.NewLine + "Your car has broken down in the country side of New York."
                + Environment.NewLine + "What do you want to do?";

            foreach (var character in myString)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }

            //This takes the users input and converts it to lower
            //Then cheacks it to the string and sees if it matchs if it does it goes to that method.
            Console.WriteLine();
            UserInPut = Console.ReadLine();

            string Boot = "open boot", GloveBox = "open glove box", UnderSeat = " look under seat", North = "go north", South = "go south", 
                East = " go east", West = "go West";

            UserInPut.ToLower();


            if (UserInPut == Boot)
            {

                BootMethod();
            }
            else if (UserInPut == GloveBox)
            {

                GloveBoxMethod();
            }
            else if (UserInPut == UnderSeat)
            {

                UnderSeatMethod();
            }
            else if (North.Contains(UserInPut))
            {
                North1();
            }
            else if (South.Contains(UserInPut))
            {
                South1();
            }
            else if (East.Contains(UserInPut))
            {
                East1();
            }
            else if (West.Contains(UserInPut))
            {
                West1();
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
                Thread.Sleep(1000);

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
                Environment.NewLine + "Tourch" +
                Environment.NewLine + "Tire Iron" +
                Environment.NewLine + "Rope" +
                Environment.NewLine + "Axe With Blood on it?";


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
                Environment.NewLine + "First Aid Kit" +
                Environment.NewLine + "Cars Manual" +
                Environment.NewLine + "Random Key";


            foreach (var character in UnderSeat)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }


        }

        public static void UnderSeatMethod()
        {
            Console.Clear();
            var UnderSeat = "You Are Under The Seat." +
                Environment.NewLine + "Lint";


            foreach (var character in UnderSeat)
            {
                Console.Write(character);
                Thread.Sleep(30);
            }

        }



        public static void Start()
        {
            Console.Clear();
            Console.WriteLine("You are still in the car.");

            string UserInPut;

            UserInPut = Console.ReadLine();

            string Boot = "open boot", GloveBox = "open glove box", UnderSeat = " look under seat", North = "go north", South = "go south", 
                East = " go east", West = "go West";


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
            else if (North.Contains(UserInPut))
            {
                North1();
            }
            else if (South.Contains(UserInPut))
            {
                South1();
            }
            else if (East.Contains(UserInPut))
            {
                East1();
            }
            else if (West.Contains(UserInPut))
            {
                West1();
            }
            else
            {

                var DidNotUnderStand = "I Do Not UnderStand."
                + Environment.NewLine + "Make Sure Your Spelling Is Right";



                foreach (var character in DidNotUnderStand)
                {
                    Console.Write(character);
                    Thread.Sleep(30);
                }

                Thread.Sleep(3000);

                Start();

            }


        }

        // this is more rroms depending on what way you go. 

        public static void North1()
        {
            Console.WriteLine("North1 method");

        }

        public static void South1()
        {
            Console.WriteLine("south1 method");


        }

        public static void East1()
        {
            Console.WriteLine("East1 method");


        }

        public static void West1()
        {
            Console.WriteLine("West1 method");


        }
    }
}
