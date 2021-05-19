using System;

namespace Jake_studio_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, play, name;
            bool playing = true;
  
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("");
            Console.WriteLine("      __________________________________________________");
            Console.WriteLine("     |                       __   _   __   __           |");
            Console.WriteLine("     |          |\\  /| |  | |__| | \\ |__  |__|          |");
            Console.WriteLine("     |          | \\/ | |__| |  \\ |_/ |__  |  \\          |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                     Book II                      |");
            Console.WriteLine("     |               Press enter to begin               |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                       |\\                         |");
            Console.WriteLine("     |                       | \\                        |");
            Console.WriteLine("     |                       | |                        |");
            Console.WriteLine("     |                       | |                        |");
            Console.WriteLine("     |                       ||                         |");
            Console.WriteLine("     |                       ||                         |");
            Console.WriteLine("     |__________________________________________________|");
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("      __________________________________________________");
            Console.WriteLine("     |                       __   _   __   __           |");
            Console.WriteLine("     |          |\\  /| |  | |__| | \\ |__  |__|          |");
            Console.WriteLine("     |          | \\/ | |__| |  \\ |_/ |__  |  \\          |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |             Would you like to play?              |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                 Y     or      N                  |");
            Console.WriteLine("     |                                                  |");
            Console.WriteLine("     |                       |\\                         |");
            Console.WriteLine("     |                       | \\                        |");
            Console.WriteLine("     |                       | |                        |");
            Console.WriteLine("     |                       | |                        |");
            Console.WriteLine("     |                       ||                         |");
            Console.WriteLine("     |                       ||                         |");
            Console.WriteLine("     |__________________________________________________|");
            
            Console.Write(" > ");
            play = Console.ReadLine();
            Console.Clear();
            if(play == "y" || play == "yes")
            {
                playing = true;
                do
                {
                    
                    Console.WriteLine(" < Enter your name ");
                    Console.Write(" > ");
                    name = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($" [Phone] < RING.... RING... RING.. ");
                    Console.ReadLine();
                    Console.WriteLine($" [{name}] < Hello?");
                    Console.ReadLine();
                    Console.WriteLine($" [Mary Thompson] < Hello, is this {name} from Sword Private Detective Agencies? ");
                    Console.ReadLine();
                    Console.WriteLine($" [{name}] < .... ah yeah well, not anymore. I retired a long time ago...");
                    Console.ReadLine();
                    Console.WriteLine(" [Mary Thompson] < I need your help... Please my husband was found dead this morning...");
                    Console.ReadLine();
                    Console.WriteLine($" [{name}] < Im sorry... I can't help you");
                    Console.ReadLine();
                    Console.WriteLine(" [Mary Thompson] < Wait! Please don't hang up. My husband is Trevor Thompson.");
                    Console.WriteLine(" [Mary Thompson] < He always told me you served in the police force together and... "); 
                    Console.WriteLine(" [Mary Thompson] < ...if anything ever happened to call you first");
                    Console.ReadLine();
                    Console.WriteLine($" [{name}] < Oh... I understand, I'll be there shortly");
                    Console.ReadLine();
                    Console.WriteLine(" [Mary Thompson] < Wait let me atleast tell you the address first...");
                    Console.WriteLine(" [Phone call ends]");
                    Console.WriteLine(" [Mary Thompson] < Hello??");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"Welcome to Murder Mystery");
                    Console.WriteLine("Created by Jake Clearwater");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($"You are {name}, A retired detective");
                    Console.WriteLine("Recently back in the business to avenge a old friend...");
                    Console.ReadLine();
                    Console.WriteLine("Explore the crime scene, gain evidence and find the true killer");
                    Console.WriteLine("Good luck");
                    Console.ReadLine();
                    Console.Clear();
                } while (playing == true);
            }
            else
            {
                Console.WriteLine("< We hope you reconsider your choice and come back soon");
                Console.ReadLine();
                playing = false;
            }

        }
    }
}
