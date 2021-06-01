using System;

namespace UntitledBookGame
{
    public partial class Program
    {
        static string temp, play, name, usr_selection;
        static bool playing = true, invalidOperator = false, leave = false, backtogame = false, leaveroom = false, evidence_caitlyn = false, evidence_caityln_2 = false, evidence_gardner_0 = false, evidence_hugo = false, evidence_molly = false, evidence_tom = false, evidence_penniworth = false, evidence_mary = false;
      static bool backtoevidence = false, backtomenu = false, pillsfound = false, itemsfound = false, hairfound = false, goback = false;
        static bool evidence_hugo_2 = false, evidence_molly_2 = false, evidence_tom_2 = false, evidence_mary_2 = false, evidence_gardner_1 = false, evidence_penniworth_1 = false, gobackinside = false;
        public static void RunMurderMysteryGame()
        {
            
            // put your games entry code here

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
                    living_room();   
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
                    usr_selection = Console.ReadLine();
                    Console.Clear();
                    switch (usr_selection)
                    {
                        case "1":
                            do
                            {
                                Outside();
                            } while (backtomenu == false);
                            Console.Clear();
                            break;

                        case "2":
                           
                            backtogame = true;
                            living_room();
                            break;

                        case "3":
                           
                            backtogame = true;
                            break;

                        case "4":
                            
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
                                Console.WriteLine("     |         < What would you like to look at:        |");
                                Console.WriteLine("     |           [1] Caitlyn     [2] Hugo               |");
                                Console.WriteLine("     |           [3] Molly       [4] Tom                |");
                                Console.WriteLine("     |           [5] Mary        [6] Mr Penniworth      |");
                                Console.WriteLine("     |           [7] Found items [8] Gardner            |");
                                Console.WriteLine("     |           [9] Go Back                            |");
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
                                    usr_selection = Console.ReadLine();
                                    switch (usr_selection)
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
                                            if (evidence_hugo_2 == true)
                                            {
                                                hugo_evidence2(); //all evidence found//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else if (evidence_hugo == true)
                                            {
                                                hugo_evidence1(); //half of the evidence
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                hugo_evidence0(); //no evidence yet//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            break;
                                        case "3":
                                            if (evidence_molly_2 == true)
                                            {
                                                molly_evidence2(); //all evidence found//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else if (evidence_molly == true)
                                            {
                                                molly_evidence1(); //half of the evidence
                                                backtoevidence = true; 
                                                Console.ReadLine();   
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                molly_evidence0(); //no evidence yet//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            break;
                                        case "4":
                                            if (evidence_tom_2 == true)
                                            {
                                                tom_evidence2(); //all evidence found//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else if (evidence_tom == true)
                                            {
                                                tom_evidence1(); //half of the evidence
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                tom_evidence0(); //no evidence yet//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            break;
                                        case "5":
                                            if (evidence_mary_2 == true)
                                            {
                                                mary_evidence2(); //all evidence found//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else if (evidence_mary == true)
                                            {
                                                mary_evidence1(); //half of the evidence
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                mary_evidence0(); //no evidence yet//
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            break;
                                        case "6":
                                            if(evidence_penniworth_1 == true)
                                            {
                                                penniworth_evidence_1();
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                penniworth_evidence_0();
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            break;
                                        case "7":
                                            if(hairfound == true && pillsfound == true)
                                            {
                                                Console.WriteLine(" Found items ");
                                                Console.WriteLine(" - Blonde hair on Trevors desk next to pills. Tom, Molly, Hugo and The Gardner all have blonde hair. It could have been planted");
                                                Console.WriteLine(" - Pills found in skip, similar to Trevors medicine");
                                            }
                                            else if(itemsfound == true)
                                            {
                                                if(pillsfound == true)
                                                {
                                                    Console.WriteLine(" Found items ");
                                                    Console.WriteLine(" - Pills found in skip, similar to Trevors medicine");
                                                }
                                                else
                                                {
                                                    Console.WriteLine(" Found items ");
                                                    Console.WriteLine(" - Blonde hair on Trevors desk next to pills. Tom, Molly, Hugo and The Gardner all have blonde hair. It could have been planted");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine(" Found items");
                                                Console.WriteLine(" - No evidence found yet");
                                                Console.ReadLine();
                                                Console.Clear();
                                                
                                            }
                                            backtoevidence = true;
                                            break;
                                        case "8":
                                            if (evidence_gardner_1 == true)
                                            {
                                                gardner_evidence_1();
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            else
                                            {
                                                gardner_evidence_0();
                                                backtoevidence = true;
                                                Console.ReadLine();
                                                Console.Clear();
                                            }
                                            break;
                                        case "9":
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

        public static void gardner_evidence_0()
        {
            Console.WriteLine("   The Gardner ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - You have not found any evidence yet");
        }
        public static void gardner_evidence_1()
        {
            Console.WriteLine("   The Gardner ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - Found Hugo is having an Affair by seeing him sneak in Caitlyns window");
        }
        public static void penniworth_evidence_0()
        {
            Console.WriteLine("  Will Penniworth ");
            Console.WriteLine("-------------------");
            Console.WriteLine(" - You have not found any evidence yet");
        }
        public static void penniworth_evidence_1()
        {
            Console.WriteLine("  Will Penniworth ");
            Console.WriteLine("-------------------");
            Console.WriteLine(" - Saw all the family grow up, Can't believe any of the family would hurt anyone");
        }
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
            Console.WriteLine(" [Hugo Tucker] No, Trevor didn't approve of me at all. He even took Molly out of his will because we got married");
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
            Console.WriteLine(" - She didn't get on with her father");
            Console.ReadLine();

        }
        public static void molly_evidence2()
        {
            Console.WriteLine("   Molly Tucker  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - She is married to Hugo, Her dad hated her for it");
            Console.WriteLine(" - She didn't get on with her father");
            Console.WriteLine(" - She doesn't know about Caitlyn and Hugo");
            Console.WriteLine(" - She thinks her mother could have killed Trevor");
            Console.ReadLine();

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
        public static void tom_evidence0()
        {
            Console.WriteLine("   Tom Thompson  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - No evidence has been found");
            Console.ReadLine();
        }
        public static void tom_evidence1()
        {
            Console.WriteLine("   Tom Thompson  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - Did not like his father and he didn't like him either");
            Console.WriteLine(" - Doesn't want to be here");
            Console.ReadLine();
        }
        public static void tom_evidence2()
        {
            Console.WriteLine("   Tom Thompson  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - Did not like his father and he didn't like him either");
            Console.WriteLine(" - Doesn't want to be here");
            Console.WriteLine(" - Doesn't have any clues who did it, likely because he doesn't care");
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
        public static void mary_evidence0()
        {
            Console.WriteLine("   Mary Thompson  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - No evidence has been found");
            Console.ReadLine();
        }
        public static void mary_evidence1()
        {
            Console.WriteLine("   Mary Thompson  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - She was married to Trevor for years and not treated well");
            Console.WriteLine(" - She was aware that he had multiple affairs");
            Console.ReadLine();
        }
        public static void mary_evidence2()
        {
            Console.WriteLine("   Mary Thompson  ");
            Console.WriteLine("------------------");
            Console.WriteLine(" - She was married to Trevor for years and not treated well");
            Console.WriteLine(" - She was aware that he had multiple affairs");
            Console.WriteLine(" - She didn't want to blame anyone but admited if it was anyone it was Tom or Molly");
            Console.ReadLine();
        }

        public static void living_room()
        {

            Console.WriteLine(" < Who would you like to speak to?");
            Console.WriteLine(" [1] Caitlyn [2] Hugo [3] Molly [4] Tom [5] Mary [6] Leave room");
            Console.Write(" > ");
            usr_selection = Console.ReadLine();
            leave = false;
            leaveroom = false;
            switch (usr_selection)
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
                        usr_selection = Console.ReadLine();
                        Console.Clear();
                        switch (usr_selection)
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
                        usr_selection = Console.ReadLine();
                        Console.Clear();
                        switch (usr_selection)
                        {
                            case "1":
                                hugo_q_1(ref name);
                                Console.Clear();
                                evidence_hugo = true;
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
                        usr_selection = Console.ReadLine();
                        Console.Clear();
                        switch (usr_selection)
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
                                evidence_molly_2 = true;
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
                        usr_selection = Console.ReadLine();
                        Console.Clear();
                        switch (usr_selection)
                        {
                            case "1":
                                tom_q_1(ref name);
                                Console.Clear();
                               
                                break;
                            case "2":
                                tom_q_2(ref name);
                                Console.Clear();
                                evidence_tom = true;
                                break;
                            case "3":
                                tom_q_3(ref name);
                                Console.Clear();
                                break;
                            case "4":
                                tom_q_4(ref name);
                                Console.Clear();
                                evidence_tom_2 = true;
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
                        usr_selection = Console.ReadLine();
                        Console.Clear();
                        switch (usr_selection)
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
                                evidence_molly_2 = true;
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
        } 

        public static void Outside()
        {
            Console.WriteLine(" You are Outside");
            Console.ReadLine();
            Console.WriteLine(" < What would you like to do?");
            Console.WriteLine(" [1] Talk to the gardner [2] Have a look around [3] Go back inside");
            Console.Write(" > ");
            usr_selection = Console.ReadLine();
            switch (usr_selection)
            { 
                case "1":
                    gardner();
                    break;
                case "2":

                    do
                    {
                     outside_looking_around();
                    } while (goback == false);
                    break; 
                case "3":
                    backtomenu = true;
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
          
        }

        public static void Upstairs()
        {
            Console.WriteLine(" You are Upstairs");
            Console.ReadLine();
            Console.WriteLine(" < What would you like to do?");
            Console.WriteLine(" [1] Look in Caitlyns Room [2] Look in Trevors Study [3] Look in the Master Bedroom [4] Go back");
            Console.Write(" > ");
            usr_selection = Console.ReadLine();
            switch (usr_selection)
            {
                case "1":
                    do
                    {
                        Console.WriteLine(" You are in Caitlyns Room");
                        Console.ReadLine();
                        Console.WriteLine(" < What would you like to do?");
                        Console.WriteLine(" [1] Look around [2] Look by the window [3] Go back");
                        Console.Write(" > ");
                        usr_selection = Console.ReadLine();
                        switch (usr_selection)
                        {
                            case "1":
                                Console.WriteLine(" You look around Caitlyns room for evidence");
                                Console.WriteLine(" The room is spotless")
                                break;
                            case "2":

                                break;
                            case "3":

                                break;
                        }
                    } while (goback == false);
                    break;
                case "2":

                    do
                    {
                        
                    } while (goback == false);
                    break;
                case "3":
                    do
                    {
                        
                    } while (goback == false);
                    break;
                case "4":
                    backtomenu = true;
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

        }
        public static void dining_room()
        {
            Console.WriteLine(" You are in the Dining Room");
            Console.ReadLine();
            Console.WriteLine(" < What would you like to do?");
            Console.WriteLine(" [1] Look around [2] Talk to Mr Penniworth [3] Go back");
            Console.Write(" > ");
            usr_selection = Console.ReadLine();
            switch (usr_selection)
            {
                case "1":
                    do
                    {

                    } while (goback == false);
                    break;
                case "2":

                    do
                    {

                    } while (goback == false);
                    break;
               
                case "3":
                    backtomenu = true;
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
        }

        public static void gardner()
        {
            Console.Clear();
            Console.WriteLine($" [{name}] Hello excuse me? Are you Mills Moffit?");
            Console.ReadLine();
            Console.WriteLine(" [Mills Moffit] Yep thats me, im the gardner around these parts. What can I do for you detective?");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Do you know anything that can help me with my investigation");
            Console.ReadLine();
            Console.WriteLine(" [Mills Moffit] Well maybe, Hugo is having an affair with Caitlyn. I see him going into her room late at night through her window when Molly is out of town");
            Console.ReadLine();
            Console.WriteLine($" [{name}] Woah thank you, that changes alot of evidence. Thank you for your time");
            Console.ReadLine();
            Console.Clear();
            evidence_gardner_1 = true;
            evidence_hugo_2 = true;
            evidence_caityln_2 = true;
        }

        public static void outside_looking_around()
        {
            
            Console.Clear();
            Console.WriteLine(" < You are outside where would you like to look?");
            Console.WriteLine(" [1] In the bushes [2] By the windows [3] In the shed [4] In the rubbish skip [5] Go back");
            Console.Write(" > ");
            usr_selection = Console.ReadLine();
            switch (usr_selection)
            {
                case "1":
                    Console.WriteLine($" [{name}] Hmm nothing here....");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "2":
                    Console.WriteLine($" [{name}] Hmm nothing here....");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "3":
                    Console.WriteLine($" [{name}] Hmm nothing here....");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4":
                    Console.WriteLine($" [{name}] Whats this?");
                    Console.ReadLine();
                    Console.WriteLine($" You have found a full bottle of pills, looks very similar to Trevors medication. Perhaps they were swapped out...");
                    Console.ReadLine();
                    Console.Clear();
                    itemsfound = true;
                    pillsfound = true;
                    break;
                case "5":
                    goback = true;
                    break;
            }
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