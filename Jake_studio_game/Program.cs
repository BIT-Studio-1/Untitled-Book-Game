using System;

namespace Jake_studio_game
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp, play, name, selection;
            bool playing = true, invalidOperator = false, choicemade = false;
  
            
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
                    Console.WriteLine($" Welcome to Murder Mystery");
                    Console.WriteLine(" Created by Jake Clearwater");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine($" You are {name}, A retired detective");
                    Console.WriteLine(" Recently back in the business to avenge a old friend...");
                    Console.ReadLine();
                    Console.WriteLine(" Explore the crime scene, gain evidence and find the true killer");
                    Console.WriteLine(" Good luck");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine(" [Story] < You pull down the driveway to find a old stone mansion. There are six cars outside");
                    Console.WriteLine("         The place is kept very clean and tidy, you notice the attention to detail, the gardens are incredible.");
                    Console.WriteLine("         You walk up to the door and knock.");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" [Door] < Knock... Knock..");
                    Console.WriteLine(" [Story] < The door flys open within seconds of knocking. A well presented gentleman stands in front of you");
                    Console.ReadLine();
                    Console.WriteLine($" [Mr Penniworth] < Good day sir, Master {name} I presume. The family is waiting for you, follow me please");
                    Console.ReadLine();
                    Console.WriteLine(" [Story] < As you walk through the home you notice 3 doors downstairs, you walk through to the door at the end of the hallway");
                    Console.WriteLine(" You enter the living room and scan across the people sitting waiting for you.");
                    Console.ReadLine();
                    Console.WriteLine($" [Mary Thompson] < {name} thank you for coming so quickly, Let me introduce you to everyone");
                    Console.ReadLine();
                    Console.WriteLine(" This is my youngest daughter, Caitlyn. My oldest daughter Molly and her Husband Hugo. And this is my oldest son Tom");
                    Console.WriteLine(" And you've met Mr Penniworth on your way in and you may have seen Mills our gardner outside");
                    Console.ReadLine();
                    Console.WriteLine($" [{name}] < Thank you, Im sorry for your loss, I'll do my best to find out what happened.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine(" < You have been introduced to everyone and know there has been a murder, You should talk to some people and gain evidence");
                    Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine(" < Who would you like to speak to first?");
                    Console.WriteLine(" [1] Caitlyn [2] Hugo [3] Molly [4] Tom [5] Mr Penniworth [6] Mary");
                    
                    
                    do
                    {
                    Console.WriteLine(" < Who would you like to speak to first?");
                    Console.WriteLine(" [1] Caitlyn [2] Hugo [3] Molly [4] Tom [5] Mr Penniworth [6] Mary");
                    Console.Write(" > ");
                    selection = Console.ReadLine();
                    choicemade = false;
                        switch (selection)
                        {
                            case "1":
                            case "caitlyn":
                            case "Caitlyn":
                                Console.Clear();
                                Console.WriteLine($" [{name}] Excuse me, Caitlyn?");
                                Console.ReadLine();
                                Console.WriteLine(" [Caitlyn Thompson] Uh, yes how can I help?");

                                choicemade = true;
                                break;
                            case "2":
                            case "Hugo":
                            case "hugo":

                                break;
                            case "3":
                            case "Molly":
                            case "molly":

                                break;
                            case "4":
                            case "Tom":
                            case "tom":

                                break;
                            case "5":
                            case "Mr Penniworth":
                            case "mr penniworth":
                            case "Mr penniworth":
                            case "mr Penniworth":

                                break;
                            case "6":
                            case "Mary":
                            case "mary":

                                break;
                            default:
                                invalidOperator = true;
                                break;
                        }
                        if (invalidOperator == true)
                        {
                            Console.WriteLine(" [Console] < Invalid input");
                            choicemade = false;
                            invalidOperator = false;
                        Console.Clear();
                        }
                    } while (choicemade == false);
                    
                
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
