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

            
                Console.WriteLine();
                UserInPut = Console.ReadLine();


            //List<string> Car = new List<string>()
            // {
            //   "Open boot", "Open glove box", "Look under seat" 
            //};



            
                

                string Boot = "open boot", GloveBox = "open glove box", UnderSeat = " look under seat";

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

                   Car();

                }
            
            


          //  if (Car.Contains(UserInPut, Car))
          //  {
          //    Console.WriteLine("Works");
          // }
          //  else
          //  {
          //   Console.WriteLine("I dont Know What that is");
          //}







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
       
    }
}
