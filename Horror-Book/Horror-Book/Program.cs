using System;
using System.Threading;
using System.Collections.Generic;

namespace Horror_Book
{
    class Program
    {
        public static void Main(string[] args)
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
            string[] Car = { "Open Boot", "Open glove box", "Look under steat" };
            UserInPut = Console.ReadLine();

            if (String.Equals(UserInPut, Car))
                {
                Console.WriteLine("Works");
            }
            else
            {
                Console.WriteLine("I dont Know What that is");
            }


         




            Console.ReadLine();
        }
    }
}
