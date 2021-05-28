using System;

namespace UntitledBookGame
{
    public partial class Program
    {
        public static void RunMurderMysteryGame()
        {
            // put your games entry code here
            string temp, play, name, selection;
            bool playing = true, invalidOperator = false, leave = false, backtogame = false, leaveroom = false, evidence_caitlyn = false, evidence_caityln_2 = false, evidence_mills = false, evidence_hugo = false, evidence_molly = true, evidence_tom = false, evidence_penniworth = false, evidence_mary = false;
            bool gooutside = false, gotolivingroom = false, goupstairs = false, gotodiningroom = false, backtoevidence = false, backtomenu = false;

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
            Console.WriteLine("     |            please play in full screen            |");
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
            if (play == "y" || play == "yes" || play == "Y")
            {
                Console.WriteLine(" < Enter your name ");
                Console.Write(" > ");
                name = Console.ReadLine();
                Console.Clear();
                introduction(ref name);

                Console.WriteLine(" You are in the living room");
                Console.ReadLine();

                do
                {
                    Console.WriteLine(" < Who would you like to speak to?");
                    Console.WriteLine(" [1] Caitlyn [2] Hugo [3] Molly [4] Tom [5] Mary [6] Leave room");
                    Console.Write(" > ");
                    selection = Console.ReadLine();
                    leave = false;
                    leaveroom = false;
                    switch (selection)
                    {
                        case "1":
                        case "caitlyn":
                        case "Caitlyn":
                            Console.Clear();
                            Console.WriteLine($" [{name}] Excuse me, Caitlyn?");
                            Console.ReadLine();
                            Console.WriteLine(" [Caitlyn Thompson] Uh, yes how can I help?");
                            Console.ReadLine();
                            Console.WriteLine($" [{name}] Would you mind I asked you a few questions to get a grip of what happened here?");
                            Console.ReadLine();
                            Console.WriteLine(" [Caitlyn Thompson] yeah sure, what did you want to know?");
                            Console.ReadLine();
                            Console.Clear();

                            do
                            {
                                Console.WriteLine(" < What would you like to do?");
                                Console.WriteLine(" [1] ask what do you know about what happened? [2] comfort her [3] ask if she killed him [4] ask who she thinks killed him [5] leave");
                                Console.Write(" > ");
                                selection = Console.ReadLine();
                                Console.Clear();
                                switch (selection)
                                {
                                    case "1":
                                        caitlyn_q_1(ref name);
                                        Console.Clear();
                                        break;
                                    case "2":
                                        caitlyn_q_2(ref name);
                                        Console.Clear();
                                        break;
                                    case "3":
                                        caitlyn_q_3(ref name);
                                        evidence_caitlyn = true;
                                        Console.Clear();
                                        break;
                                    case "4":
                                        caitlyn_q_4(ref name);
                                        Console.Clear();
                                        break;
                                    case "5":
                                        Console.WriteLine($" [{name}] Thank you, that should do");
                                        Console.ReadLine();
                                        Console.Clear();
                                        leave = true;
                                        break;
                                    default:
                                        invalidOperator = true;
                                        break;
                                }
                                if (invalidOperator == true)
                                {
                                    Console.WriteLine(" [Console] < Invalid input");

                                    invalidOperator = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                            } while (leave == false);

                            break;
                        case "2":
                        case "Hugo":
                        case "hugo":
                            Console.Clear();
                            Console.WriteLine($" [{name}] Excuse me, Hugo?");
                            Console.ReadLine();
                            Console.WriteLine(" [Hugo Tucker] yep how can I help?");
                            Console.ReadLine();
                            Console.WriteLine($" [{name}] Would you mind I asked you a few questions to get a grip of what happened here?");
                            Console.ReadLine();
                            Console.WriteLine(" [Hugo Tucker] yeah sure, what did you want to know?");
                            Console.ReadLine();
                            Console.Clear();

                            do
                            {
                                Console.WriteLine(" < What would you like to do?");
                                Console.WriteLine(" [1] ask what do you know about what happened? [2] ask if he killed him [3] ask who he thinks killed him [4] leave");
                                Console.Write(" > ");
                                selection = Console.ReadLine();
                                Console.Clear();
                                switch (selection)
                                {
                                    case "1":
                                        hugo_q_1(ref name);
                                        Console.Clear();
                                        break;
                                    case "2":
                                        hugo_q_2(ref name);
                                        Console.Clear();
                                        break;
                                    case "3":
                                        hugo_q_3(ref name);
                                        evidence_hugo = true;
                                        Console.Clear();
                                        break;
                                    case "4":
                                        Console.WriteLine($" [{name}] Thank you, that should do");
                                        Console.ReadLine();
                                        Console.Clear();
                                        leave = true;
                                        break;
                                    default:
                                        invalidOperator = true;
                                        break;
                                }
                                if (invalidOperator == true)
                                {
                                    Console.WriteLine(" [Console] < Invalid input");

                                    invalidOperator = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                            } while (leave == false);

                            break;
                        case "3":
                        case "Molly":
                        case "molly":
                            Console.Clear();
                            Console.WriteLine($" [{name}] Excuse me, Molly?");
                            Console.ReadLine();
                            Console.WriteLine(" [Molly Tucker] Yes, What do you want?");
                            Console.ReadLine();
                            Console.WriteLine($" [{name}] Would you mind I asked you a few questions to get a grip of what happened here?");
                            Console.ReadLine();
                            Console.WriteLine(" [Molly Tucker] yeah sure whatever...");
                            Console.ReadLine();
                            Console.Clear();

                            do
                            {
                                Console.WriteLine(" < What would you like to do?");
                                Console.WriteLine(" [1] ask what do you know about what happened? [2] comfort her [3] ask if she killed him [4] ask who she thinks killed him [5] leave");
                                Console.Write(" > ");
                                selection = Console.ReadLine();
                                Console.Clear();
                                switch (selection)
                                {
                                    case "1":
                                        molly_q_1(ref name);
                                        Console.Clear();
                                        break;
                                    case "2":
                                        molly_q_2(ref name);
                                        Console.Clear();
                                        evidence_molly = true;
                                        break;
                                    case "3":
                                        molly_q_3(ref name);
                                        Console.Clear();
                                        break;
                                    case "4":
                                        molly_q_4(ref name);
                                        Console.Clear();
                                        break;
                                    case "5":
                                        Console.WriteLine($" [{name}] Thank you, that should do");
                                        Console.ReadLine();
                                        Console.Clear();
                                        leave = true;
                                        break;
                                    default:
                                        invalidOperator = true;
                                        break;
                                }
                                if (invalidOperator == true)
                                {
                                    Console.WriteLine(" [Console] < Invalid input");

                                    invalidOperator = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                            } while (leave == false);

                            break;
                        case "4":
                        case "Tom":
                        case "tom":
                            Console.Clear();
                            Console.WriteLine($" [{name}] Excuse me, Tom?");
                            Console.ReadLine();
                            Console.WriteLine(" [Tom Thompson] Yes, What do you want?");
                            Console.ReadLine();
                            Console.WriteLine($" [{name}] Would you mind I asked you a few questions to get a grip of what happened here?");
                            Console.ReadLine();
                            Console.WriteLine(" [Tom Thompson] if you must");
                            Console.ReadLine();
                            Console.Clear();

                            do
                            {
                                Console.WriteLine(" < What would you like to do?");
                                Console.WriteLine(" [1] ask what do you know about what happened? [2] comfort him [3] ask if he killed him [4] ask who he thinks killed him [5] leave");
                                Console.Write(" > ");
                                selection = Console.ReadLine();
                                Console.Clear();
                                switch (selection)
                                {
                                    case "1":
                                        tom_q_1(ref name);
                                        Console.Clear();
                                        evidence_tom = true;
                                        break;
                                    case "2":
                                        tom_q_2(ref name);
                                        Console.Clear();
                                        break;
                                    case "3":
                                        tom_q_3(ref name);
                                        Console.Clear();
                                        break;
                                    case "4":
                                        tom_q_4(ref name);
                                        Console.Clear();
                                        break;
                                    case "5":
                                        Console.WriteLine($" [{name}] Thank you, that should do");
                                        Console.ReadLine();
                                        Console.Clear();
                                        leave = true;
                                        break;
                                    default:
                                        invalidOperator = true;
                                        break;
                                }
                                if (invalidOperator == true)
                                {
                                    Console.WriteLine(" [Console] < Invalid input");

                                    invalidOperator = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                            } while (leave == false);
                            break;



                        case "5":
                        case "Mary":
                        case "mary":
                            Console.Clear();
                            Console.WriteLine($" [{name}] Excuse me, Mary?");
                            Console.ReadLine();
                            Console.WriteLine(" [Mary Thompson] Yes, How can i help?");
                            Console.ReadLine();
                            Console.WriteLine($" [{name}] Would you mind I asked you a few questions to get a grip of what happened here?");
                            Console.ReadLine();
                            Console.WriteLine(" [Mary Thompson] Of course");
                            Console.ReadLine();
                            Console.Clear();

                            do
                            {
                                Console.WriteLine(" < What would you like to do?");
                                Console.WriteLine(" [1] ask what do you know about what happened? [2] comfort her [3] ask if she killed him [4] ask who she thinks killed him [5] leave");
                                Console.Write(" > ");
                                selection = Console.ReadLine();
                                Console.Clear();
                                switch (selection)
                                {
                                    case "1":
                                        mary_q_1(ref name);
                                        Console.Clear();
                                        evidence_mary = true;
                                        break;
                                    case "2":
                                        mary_q_2(ref name);
                                        Console.Clear();
                                        break;
                                    case "3":
                                        mary_q_3(ref name);
                                        Console.Clear();
                                        break;
                                    case "4":
                                        mary_q_4(ref name);
                                        Console.Clear();
                                        break;
                                    case "5":
                                        Console.WriteLine($" [{name}] Thank you, that should do");
                                        Console.ReadLine();
                                        Console.Clear();
                                        leave = true;
                                        break;
                                    default:
                                        invalidOperator = true;
                                        break;
                                }
                                if (invalidOperator == true)
                                {
                                    Console.WriteLine(" [Console] < Invalid input");

                                    invalidOperator = false;
                                    Console.ReadLine();
                                    Console.Clear();
                                }

                            } while (leave == false);

                            break;
                        case "6":
                            Console.WriteLine(" You have left the room");
                            Console.ReadLine();
                            leaveroom = true;
                            Console.Clear();
                            break;

                        default:
                            invalidOperator = true;
                            break;
                    }
                    if (invalidOperator == true)
                    {
                        Console.WriteLine(" [Console] < Invalid input");

                        invalidOperator = false;
                        Console.ReadLine();
                        Console.Clear();
                    }
                } while (leaveroom == false);
                do
                {

                    backtogame = false;
                    Console.WriteLine("");  //pause menu//
                    Console.WriteLine("      __________________________________________________");
                    Console.WriteLine("     |                                                  |");
                    Console.WriteLine("     |                                                  |");
                    Console.WriteLine("     |            What would you like to do?            |");
                    Console.WriteLine("     |                                                  |");
                    Console.WriteLine("     |                                                  |");
                    Console.WriteLine("     |    [1] Go Outside       [2] Go to Living room    |");
                    Console.WriteLine("     |    [3] Go Upstairs      [4] Go To Dining Room    |");
                    Console.WriteLine("     |    [5] Check evidence                            |");
                    Console.WriteLine("     |                                                  |");
                    Console.WriteLine("     |                       |\\                         |");
                    Console.WriteLine("     |                       | \\                        |");
                    Console.WriteLine("     |                       | |                        |");
                    Console.WriteLine("     |                       | |                        |");
                    Console.WriteLine("     |                       ||                         |");
                    Console.WriteLine("     |                       ||                         |");
                    Console.WriteLine("     |__________________________________________________|");

                    
                        Console.Write(" > ");
                        selection = Console.ReadLine();
                        Console.Clear();
                        switch (selection)
                        {
                            case "1":
                                gooutside = true;
                                backtogame = true;
                                break;

                            case "2":
                                gotolivingroom = true;
                                backtogame = true;
                                break;

                            case "3":
                                goupstairs = true;
                                backtogame = true;
                                break;

                            case "4":
                                gotodiningroom = true;
                                backtogame = true;
                                break;

                            case "5":

                                do
                                {
                                    backtomenu = false;
                                    Console.Clear();
                                    Console.WriteLine("");   //inventory//
                                    Console.WriteLine("      __________________________________________________");
                                    Console.WriteLine("     |                                                  |");
                                    Console.WriteLine("     |                                                  |");
                                    Console.WriteLine("     |                 Evidence Locker:                 |");
                                    Console.WriteLine("     |                                                  |");
                                    Console.WriteLine("     |         < What would you like to look at:        |");
                                    Console.WriteLine("     |            [1] Caitlyn    [2] Hugo               |");
                                    Console.WriteLine("     |            [3] Molly      [4] Tom                |");
                                    Console.WriteLine("     |            [5] Mary       [6] Mr Penniworth      |");
                                    Console.WriteLine("     |            [7] Found items[8] Go back            |");
                                    Console.WriteLine("     |                       |\\                         |");
                                    Console.WriteLine("     |                       | \\                        |");
                                    Console.WriteLine("     |                       | |                        |");
                                    Console.WriteLine("     |                       | |                        |");
                                    Console.WriteLine("     |                       ||                         |");
                                    Console.WriteLine("     |                       ||                         |");
                                    Console.WriteLine("     |__________________________________________________|");

                                    do
                                    {
                                        backtoevidence = false;
                                        Console.Write(" > ");
                                        selection = Console.ReadLine();
                                        switch (selection)
                                        {
                                            case "1":
                                                if (evidence_caityln_2 == true)
                                                {
                                                    caitlyn_evidence2(); //all evidence found//
                                                    backtoevidence = true;
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                                else if (evidence_caitlyn == true)
                                                {
                                                    caitlyn_evidence1(); //half of the evidence
                                                    backtoevidence = true;
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                                else
                                                {
                                                    caitlyn_evidence0(); //no evidence yet//
                                                    backtoevidence = true;
                                                    Console.ReadLine();
                                                    Console.Clear();
                                                }
                                                break;
                                            case "2":

                                                break;
                                            case "3":

                                                break;
                                            case "4":

                                                break;
                                            case "5":

                                                break;
                                            case "6":

                                                break;
                                            case "7":

                                                break;
                                            case "8":
                                            Console.WriteLine("Back to menu");
                                            Console.ReadLine();
                                            Console.Clear();
                                                backtomenu = true;
                                            backtoevidence = true;
                                                break;

                                        }
                                    } while (backtoevidence == false);
                                } while (backtomenu == false);
                                break;

                            default:
                                invalidOperator = true;
                                break;
                        }
                        if (invalidOperator == true)
                        {
                            Console.WriteLine(" [Console] < Invalid input");

                            invalidOperator = false;
                            Console.ReadLine();
                            Console.Clear();
                        }


                    
                } while (backtogame == false);


            }
            else
            {
                Console.WriteLine("< We hope you reconsider your choice and come back soon");
                Console.ReadLine();
                playing = false;
            }
        }






        // other game code, methods, etc.


        public static void caitlyn_q_1(ref string name)
        {
            Console.WriteLine($" [{name}] What do you know about what happened?");
            Console.ReadLine();
            Console.WriteLine(" [Caitlyn Thompson] Not much, I only got told about a hour ago, Mum said she found him in his study with a bunch of pills and whiskey");
            Console.WriteLine(" I believe it was someone in the family, he changed his will last month. Not everyone was happy");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Were you happy?");
            Console.ReadLine();
            Console.WriteLine(" [Caitlyn Thompson] Well... of course. it was changed in favour of me");
            Console.ReadLine();

        }
        public static void caitlyn_q_2(ref string name)
        {
            Console.WriteLine($" [{name}] Im sorry about your loss... I won't stop until I found out who did this. You have my word");
            Console.ReadLine();
            Console.WriteLine(" [Caitlyn Thompson] Thank you, it means alot to us...");
            Console.ReadLine();

        }
        public static void caitlyn_q_3(ref string name)
        {
            Console.WriteLine($" [{name}] I'll get right to the chase... Did you kill your father?");
            Console.ReadLine();
            Console.WriteLine(" [Caitlyn Thompson] No of course not! how dare you I loved my father");
            Console.ReadLine();
        }
        public static void caitlyn_q_4(ref string name)
        {
            Console.WriteLine($" [{name}] Who do you think killed him?");
            Console.ReadLine();
            Console.WriteLine(" [Caitlyn Thompson] Well mum made it sound like suicide but Molly had the most to gain from doing it");
            Console.WriteLine(" She was cut out of the will because Dad hated Hugo");
            Console.ReadLine();

        }
        public static void caitlyn_evidence0()
        {
            Console.WriteLine(" Caitlyn Thompson ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - You have not found any evidence yet");
        }
        public static void caitlyn_evidence1()
        {
            Console.WriteLine(" Caitlyn Thompson ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - Caitlyn is the youngest daughter and presumably the favourite child");
            Console.WriteLine(" - She was very fast to shift the blame to her sister, unusual response for family");
            Console.ReadLine();
        }
        public static void caitlyn_evidence2()
        {
            Console.WriteLine(" Caitlyn Thompson ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - Caitlyn is the youngest daughter and presumably the favourite child");
            Console.WriteLine(" - She was very fast to shift the blame to her sister, unusual response for family");
            Console.WriteLine(" - The Gardner mentioned he often saw Hugo entering Caitlyns room late at night, Possibily a affair");
            Console.WriteLine(" - Mr Penniworth said growing up she always hated Molly");
        }
        public static void hugo_q_1(ref string name)
        {
            Console.WriteLine($" [{name}] What do you know about what happened?");
            Console.ReadLine();
            Console.WriteLine(" [Hugo Tucker] A little... Mary told me was found in his study and she thinks someone had killed him but Caitlyn told me it was suicide");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Were you included in his will that was changed recently?");
            Console.ReadLine();
            Console.WriteLine(" [Hugo Tucker] No, Trevor didn't approve of me at all. He even took Molly out of his will because of me");
            Console.ReadLine();

        }

        public static void hugo_q_2(ref string name)
        {
            Console.WriteLine($" [{name}] I'll get right to the chase... Did you kill Trevor?");
            Console.ReadLine();
            Console.WriteLine(" [Hugo Tucker] What the hell! no of course not... we didn't get on but I would never do something like that");
            Console.ReadLine();
        }
        public static void hugo_q_3(ref string name)
        {
            Console.WriteLine($" [{name}] Who do you think killed him?");
            Console.ReadLine();
            Console.WriteLine(" [Hugo Tucker] Well if it was anyone it would have to be Tom, He hated him the most");
            Console.ReadLine();

        }

        public static void hugo_evidence0()
        {
            Console.WriteLine("    Hugo Tucker  ");
            Console.WriteLine("-------------------");
            Console.WriteLine(" - No evidence has been found");
            Console.ReadLine();
        }
        public static void hugo_evidence1()
        {
            Console.WriteLine("    Hugo Tucker  ");
            Console.WriteLine("-------------------");
            Console.WriteLine(" - He is married to Molly Thompson");
            Console.WriteLine(" - Trevor did not approve of him. Removed Molly out of his Will because of his disapproval");
            Console.WriteLine(" - He believes it was Tom who killed Trevor");
            Console.ReadLine();
        }
        public static void hugo_evidence2()
        {
            Console.WriteLine("    Hugo Tucker  ");
            Console.WriteLine("-------------------");
            Console.WriteLine(" - He is married to Molly Thompson");
            Console.WriteLine(" - Trevor did not approve of him. Removed Molly out of his Will because of his disapproval");
            Console.WriteLine(" - He believes it was Tom who killed Trevor");
            Console.WriteLine(" - He is having an affair with Caitlyn");
            Console.WriteLine("");
        }

        public static void molly_q_1(ref string name)
        {
            Console.WriteLine($" [{name}] What do you know about what happened?");
            Console.ReadLine();
            Console.WriteLine(" [Molly Tucker] All I know is that hes dead... I don't keep in contact much with my family");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Were you apart of the will that was recently changed?");
            Console.ReadLine();
            Console.WriteLine(" [Molly Tucker] Well... of course. it was changed to keep me away from any of his belongings and money");
            Console.ReadLine();
        }
        public static void molly_q_2(ref string name)
        {
            Console.WriteLine($" [{name}] Im sorry about your loss... I won't stop until I found out who did this. You have my word");
            Console.ReadLine();
            Console.WriteLine(" [Molly Tucker] Thank you, but those kind words would mean more to someone who actually cared for him");
            Console.ReadLine();
        }
        public static void molly_q_3(ref string name)
        {
            Console.WriteLine($" [{name}] I'll get right to the chase... Did you kill your father?");
            Console.ReadLine();
            Console.WriteLine(" [Molly Tucker] I hated him but I would never actually hurt him");
            Console.ReadLine();
        }
        public static void molly_evidence0()
        {
            Console.WriteLine("   Molly Tucker  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - No evidence has been found");
            Console.ReadLine();
        }
        public static void molly_evidence1()
        {
            Console.WriteLine("   Molly Tucker  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - She is married to Hugo, Her dad hated her for it");
            Console.ReadLine();
        }
        public static void molly_evidence2()
        {
            Console.WriteLine("   Molly Tucker  ");
            Console.WriteLine("------------------");
            
        }

        public static void molly_q_4(ref string name)
        {
            Console.WriteLine($" [{name}] Who do you think killed him?");
            Console.ReadLine();
            Console.WriteLine(" [Molly Tucker] Well he treated mum like shit for 30 years but I would have no clue");
            Console.ReadLine();

        }
        public static void tom_q_1(ref string name)
        {
            Console.WriteLine($" [{name}] What do you know about what happened?");
            Console.ReadLine();
            Console.WriteLine(" [Tom Thompson] Nothing except that hes finally dropped dead");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Were you father not on good terms?");
            Console.ReadLine();
            Console.WriteLine(" [Tom Thompson] No, I was his only son and a disapointment so I wasn't given much time of day...");
            Console.ReadLine();

        }
        public static void tom_q_2(ref string name)
        {
            Console.WriteLine($" [{name}] Im sorry about your loss... I won't stop until I found out who did this. You have my word");
            Console.ReadLine();
            Console.WriteLine(" [Tom Thompson] Thank you, the faster this is over with the faster I can get out of this awful house");
            Console.ReadLine();

        }
        public static void tom_q_3(ref string name)
        {
            Console.WriteLine($" [{name}] I'll get right to the chase... Did you kill your father?");
            Console.ReadLine();
            Console.WriteLine(" [Tom Thompson] Wouldn't it be great if your job was that easy....");
            Console.WriteLine(" I was kidding, No I didnt kill him...");
            Console.ReadLine();
        }
        public static void tom_q_4(ref string name)
        {
            Console.WriteLine($" [{name}] Who do you think killed him?");
            Console.ReadLine();
            Console.WriteLine(" [Tom Thompson] No idea. your the detective aren't you?");
            Console.ReadLine();

        }
        public static void mary_q_1(ref string name)
        {
            Console.WriteLine($" [{name}] What do you know about what happened?");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] Well I found him in his studio with pills all over the desk and whiskey everywhere, but I know my Husband he would never");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Were you happy with him?");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] Well... of course. Well actually no, he always cheated on me with different women every week... I would look the other way to keep him happy");
            Console.ReadLine();

        }
        public static void mary_q_2(ref string name)
        {
            Console.WriteLine($" [{name}] Im sorry about your loss... I won't stop until I found out who did this. You have my word");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] Thank you, it would mean alot to us...");
            Console.ReadLine();

        }
        public static void mary_q_3(ref string name)
        {
            Console.WriteLine($" [{name}] Did you kill your Husband?");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] No of course not! how dare you I loved my husband");
            Console.ReadLine();
        }
        public static void mary_q_4(ref string name)
        {
            Console.WriteLine($" [{name}] Who do you think killed him?");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] I would hate to blame any of my kids but Tom and Molly hated him the most...");

            Console.ReadLine();

        }





        public static void introduction(ref string name)
        {

            Console.WriteLine($" [Phone] RING.... RING... RING.. ");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Hello?");
            Console.ReadLine();
            Console.WriteLine($" [Mary Thompson] Hello, is this {name} from Sword Private Detective Agencies? ");
            Console.ReadLine();
            Console.WriteLine($" [{name}] .... ah yeah well, not anymore. I retired a long time ago...");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] I need your help... Please my husband was found dead this morning...");
            Console.ReadLine();
            Console.WriteLine($" [{name}] < Im sorry... I can't help you");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] Wait! Please don't hang up. My husband is Trevor Thompson.");
            Console.WriteLine(" [Mary Thompson] He always told me you served in the police force together and... ");
            Console.WriteLine(" [Mary Thompson] ...if anything ever happened to call you first");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Oh... I understand, I'll be there shortly");
            Console.ReadLine();
            Console.WriteLine(" [Mary Thompson] Wait let me atleast tell you the address first...");
            Console.WriteLine(" [Phone call ends]");
            Console.WriteLine(" [Mary Thompson] Hello??");
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

            Console.WriteLine(" [Story] You pull down the driveway to find a old stone mansion. There are six cars outside");
            Console.WriteLine("         The place is kept very clean and tidy, you notice the attention to detail, the gardens are incredible.");
            Console.WriteLine("         You walk up to the door and knock.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(" [Door] Knock... Knock..");
            Console.WriteLine(" [Story] The door flys open within seconds of knocking. A well presented gentleman stands in front of you");
            Console.ReadLine();
            Console.WriteLine($" [Mr Penniworth] Good day sir, Master {name} I presume. The family is waiting for you, follow me please");
            Console.ReadLine();
            Console.WriteLine(" [Story] As you walk through the home you notice 3 doors downstairs, you walk through to the door at the end of the hallway");
            Console.WriteLine(" You enter the living room and scan across the people sitting waiting for you.");
            Console.ReadLine();
            Console.WriteLine($" [Mary Thompson] {name} thank you for coming so quickly, Let me introduce you to everyone");
            Console.ReadLine();
            Console.WriteLine(" This is my youngest daughter, Caitlyn. My oldest daughter Molly and her Husband Hugo. And this is my oldest son Tom");
            Console.WriteLine(" And you've met Mr Penniworth on your way in and you may have seen Mills our gardner outside");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Thank you, Im sorry for your loss, I'll do my best to find out what happened.");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine(" < You have been introduced to everyone and know there has been a murder, You should talk to some people and gain evidence");
            Console.ReadLine();
            Console.Clear();
        }



    }
}