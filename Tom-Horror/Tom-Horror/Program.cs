using System;
using System.Threading;
using System.Collections;
using System.Collections.Generic;

namespace Horror_Book
{
    class Program
    {
        public static void Main(string[] args)
        {
            Car();
            

            
        }

        public static void Car()
        {
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
                    Console.WriteLine("I Do Not Under Stand");
                    Console.WriteLine("Make Sure That You Are Not Using Capitals");
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

        public static void BootMethod()
        {
            Console.Clear();
            Console.WriteLine("Your in the Boot");

        }

        public static void GloveBoxMethod()
        {
            Console.Clear();
            Console.WriteLine("Your in the Glove Box");
        }

        public static void UnderSeatMethod()
        {
            Console.Clear();
            Console.WriteLine("Your under the seat");
        }

       
    }
}
