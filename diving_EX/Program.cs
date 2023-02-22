using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace diving_EX
{
    class Program
    {
        public static Diver Register()
        {

            Console.Write("Enter your first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your last name : ");
            string lastName = Console.ReadLine();
            Console.Write("Enter your birth date : ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Enter your email : ");
            string userName = Console.ReadLine();
            Console.Write("enter your password : ");
            string password = Console.ReadLine();

            Diver diver = new Diver(firstName, lastName, birthDate, userName, password);


            return diver;
        }


        static void Main(string[] args)
        {
            Country Bulgaria = new Country("Bulgaria", "rrr43d");
            Country Colombia = new Country("Colombia", "0.877f");




            Rank oneStar = new Rank("junior diver", "A diver who performed less than five dives", 1);

            Rank twoStars = new Rank("Advanced diver", "A diver who performed between five and ten dives", 2);

            Rank treeStars = new Rank("expert diver", "A diver who performed over ten dives", 3);


            //Rank[] ranks = new Rank[] { oneStar, twoStars, treeStars };
            Club Oceanic = new Club(11784, "Oceanic", Bulgaria, "Mahesh Chand", "Bogotá", "Blue sky", "07774512", "Oceanic@diving.bu");
            Club Submariners = new Club(33310, "The Submariners", Colombia, "Neel Beniwal", "Sofia", "Main Avenue", "08874371", "Submariners@the.com");

            List<Club> clubs = new List<Club>
            {
                Oceanic,
                Submariners
            };





            Rank[] divingRankFirst = new Rank[2];
            divingRankFirst[0] = oneStar;
            divingRankFirst[1] = twoStars;

            Rank[] divingRankSecond = new Rank[3];
            divingRankSecond[0] = oneStar;
            divingRankSecond[1] = twoStars;
            divingRankSecond[2] = treeStars;



            Diary divingDairyFirst = new Diary(new Dive[0]);




            Club[] workPlacesFirst = new Club[] { Oceanic };

            DateTime[] startDatesFirst = new DateTime[] { new DateTime(2019, 2, 15) };
            DateTime[] endDatesFirst = new DateTime[] { new DateTime(2019, 6, 6) };



            Diary divingDairySecond = new Diary(new Dive[0]);
            Club[] workPlacesSecond = new Club[] { Oceanic, Submariners };
            DateTime[] startDatesSecond = new DateTime[] { new DateTime(2008, 1, 4), new DateTime(2015, 10, 14) };
            DateTime[] endDatesSecond = new DateTime[] { new DateTime(2010, 8, 12), new DateTime(2020, 7, 1) };


            Diver firstInstructor = new Instructor("Mahesh", " Chand", new DateTime(2001, 6, 1), "WavesWhisperer@g.bu", "12345678", divingRankFirst, divingDairyFirst, workPlacesFirst, startDatesFirst, endDatesFirst);
            Diver secondtInstructor = new Instructor("Neel", "Beniwal", new DateTime(1990, 12, 30), "SeaMaster@g.com", "87654321", divingRankSecond, divingDairySecond, workPlacesSecond, startDatesSecond, endDatesSecond);



            //.ToString("dd/MM/yyyy")


            List<DivingSite> divingSites = new List<DivingSite>();
            divingSites.Add(new DivingSite("Blue Heron", Bulgaria, "Flower Street", "In the water, lies the world’s second largest coral reef", 152.4, 914.4, "sweet water"));
            divingSites.Add(new DivingSite("Nemo's City", Colombia, "Bee Street", "There is not much to see above the surface but underwater it’s another story", 76.2, 300.53, "seawater"));



            Dictionary<string, Diver> diverDetailsDictionary = new Dictionary<string, Diver>();
            Dictionary<string, Diver> diversDictionaryByName = new Dictionary<string, Diver>();

            diversDictionaryByName.Add(firstInstructor.GetFirstName(), firstInstructor);
            diversDictionaryByName.Add(secondtInstructor.GetFirstName(), secondtInstructor);
            diverDetailsDictionary.Add(firstInstructor.GetUserName(), firstInstructor);
            diverDetailsDictionary.Add(secondtInstructor.GetUserName(), secondtInstructor);


            Dictionary<string, Diver> GetDiverDetailsDictionary()
            {
                return diverDetailsDictionary;
            }

            Dictionary<string, Diver> GetDiversDictionaryByName()
            {

                return diversDictionaryByName;
            }

            Gear wetSuit = new Gear("Wetsuit", 571);
            Gear tank = new Gear("tank", 240);
            Gear belt = new Gear("dive belt", 23);
            Gear Light = new Gear("Light", 39);
            Gear Snorkels = new Gear("Snorkels", 72);
            Gear fins = new Gear("fins", 114);

            Gear Compass = new Gear("Compass", 83);
            Gear camera = new Gear("camera", 313);

            Gear[] globalGears = new Gear[] { wetSuit, tank, belt, Light, Snorkels, fins, Compass, camera };





            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Blue;
            while (true)
            {


                Console.WriteLine("Welcome to the world of divers");
                Console.WriteLine("1. Sign Up" +

            Environment.NewLine + "2. Sign In");



                var ans = Console.ReadLine();


                if (int.TryParse(ans, out int choice))
                {

                    switch (choice)
                    {

                        case 1:
                            Diver diver = Register();
                            if (diver != null) diverDetailsDictionary.Add(diver.GetUserName(), diver);

                            break;



                        case 2:
                            Login();
                            break;
                        default:

                            Console.WriteLine("Wrong selection!!!" +

                                Environment.NewLine + "Press any kay for exit");

                            Console.ReadKey();

                            break;

                    }

                }

                else

                {

                    Console.WriteLine("You must type numeric value only!!!" +

                        Environment.NewLine + "Press any kay for exit");

                    Console.ReadKey();

                }
                Console.Clear();











            }

            void Login()
            {

                Dictionary<string, Diver> diversDictionary = GetDiverDetailsDictionary();



                Console.Write("Enter your email : ");
                string loginUserName = Console.ReadLine();
                Console.Write("enter your password : ");
                string loginPassword = Console.ReadLine();

                if (!(diversDictionary.TryGetValue(loginUserName, out Diver currentDiver) && currentDiver.GetPassword().Equals(loginPassword)))
                {
                    Console.WriteLine("User Or Password are incorrect\n Press any kay for exit");
                    Console.ReadKey();
                    return;

                }

                Console.Clear();
                diverMethods(currentDiver);




            }
            Club locateClub(string club)
            {


                Club found = clubs.FirstOrDefault(item => item.GetName().ToLower() == club.ToLower());
                return found;
            }
            void diverMethods(Diver currentDiver)
            {
                object signature = "greatdive";


                while (true)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Welcome Diver !!! ");
                    Console.WriteLine("1. locate club " +

                Environment.NewLine + "2. Enter a new dive details" +
                  Environment.NewLine + "3. update  rank" +
                    Environment.NewLine + "4. scan noteBook " +
                     Environment.NewLine + "5. Add a signature to a dive " +
                     Environment.NewLine + "6. Exit " );



                    var ans = Console.ReadLine();


                    if (int.TryParse(ans, out int choice))

                    {


                        switch (choice)

                        {

                            case 1:
                                {


                                    Console.WriteLine("enter the club name : ");
                                    string name = Console.ReadLine();
                                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                    Console.WriteLine(locateClub(name));
                                    Console.ReadKey();

                                }
                                break;



                            case 2:
                                {

                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    if (!(currentDiver is Instructor))
                                    {
                                        Console.WriteLine("Wrong selection.Intended for instructors only" +

                                   Environment.NewLine + "Press any key for exit");

                                        Console.ReadKey();
                                    }
                                    else
                                    {
                                        regDive(currentDiver);


                                    }




                                }
                                break;

                            case 3:
                                {
                                    reRanking(currentDiver);
                                }
                                break;
                            case 4:
                                {
                                    if (currentDiver.GetDivingDairy() != null)
                                    {
                                        Console.WriteLine("The diving details must be filled in first !!");
                                        Console.ReadKey();
                                        break;
                                    }
                                    Diary divingDairy = new Diary(new Dive[] { regDive(currentDiver) });

                                    currentDiver.scanNoteBook(divingDairy);

                                }
                                break;
                            case 5:
                                {
                                    if (currentDiver.GetDivingDairy() != null)
                                    {
                                        Console.WriteLine("The diving details must be filled in first !!");
                                        Console.ReadKey();
                                        break;
                                    }
                                    signOnDive(regDive(currentDiver));

                                }
                                break;
                            case 6:
                                {
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    return;
                                }

                          



                            default:

                                Console.WriteLine("Wrong selection!!!" +

                                    Environment.NewLine + "Press any key for exit");

                                Console.ReadKey();

                                break;

                        }

                    }

                    else

                    {

                        Console.WriteLine("You must type numeric value only!!!" +

                            Environment.NewLine + "Press any kay for exit");

                        Console.ReadKey();

                    }
                    Console.Clear();





                }
            }


            Dive regDive(Diver diver)
            {

                Dictionary<string, Diver> DiversDictionaryByName = GetDiversDictionaryByName();
                Console.Write("enter diving Club : ");
                Club divingClub = locateClub(Console.ReadLine());

                if (divingClub == null)
                {
                    Console.WriteLine("There is no diving Club in the name you specified");
                    Console.ReadKey();
                    return null;
                }
                Console.Write("enter your diving Instructor : ");
                string instructorName = Console.ReadLine();


                if (!(DiversDictionaryByName.TryGetValue(instructorName, out Diver instructor)))
                {
                    Console.WriteLine("There is no dive guide in the name you specified");
                    Console.ReadKey();
                    return null;

                }
                Console.WriteLine("Type the equipment you took for the dive : ");
                string equipment = Console.ReadLine();

                string[] subs = equipment.Split(' ');
                Gear[] gears = new Gear[subs.Length];
               
                for (int i = 0, k = 0; i < subs.Length; i++)
                {
                    for (int j = 0; j < globalGears.Length; j++)
                    {
                        if (globalGears[j].GetName().ToLower() == subs[i].ToLower())
                        {
                           
                            gears[k] = new Gear(globalGears[j]);
                            Console.WriteLine($"Type the amount of {gears[k].GetName()} you took :");
                            int amount = int.Parse(Console.ReadLine());
                            gears[k].SetAmount(amount);
                            Console.WriteLine("Want to add a comment? y to add one. ");
                           char answer = char.Parse(Console.ReadLine());
                            if (answer == 'y')
                            {
                                gears[k].SetNote(Console.ReadLine());
                            }


                            k++;

                        }
                    }
                }



                Diver[] diversInDive = new Diver[] { diver, instructor };
                DateTime startTime;
                DateTime endTime;
                Console.Write("enter start hour : ");
                string startingHour = Console.ReadLine();


                string time, hourcheack;
                if (DateTime.TryParse(startingHour, out DateTime hour))

                {
                    time = hour.ToString("HH:mm");

                    hourcheack = time.Substring(0, 2);

                    int hourInt = int.Parse(hourcheack);

                    if (hourInt >= 24)

                    {

                        throw new ArgumentOutOfRangeException(hourInt.ToString(), "Invalid hour");

                    }

                }
                startTime = hour;

                Console.Write("enter end hour : ");

                string endingHour = Console.ReadLine();

                if (DateTime.TryParse(endingHour, out hour))

                {
                    time = hour.ToString("HH:mm");

                    hourcheack = time.Substring(0, 2);

                    int hourInt = int.Parse(hourcheack);

                    if (hourInt >= 24)

                    {

                        throw new ArgumentOutOfRangeException(hourInt.ToString(),"Invalid hour");

                    }

                }
                endTime = hour;

                Console.Write("Enter the water temp : ");
                double waterTemp = double.Parse(Console.ReadLine());
                Console.Write("Enter the water status (geut / shefel ) : ");
                string waterStatus = Console.ReadLine();
                Console.Write("Enter the Diving Site : ");
                string siteName = Console.ReadLine();
                DivingSite site = null;
                foreach (DivingSite divingSite in divingSites)
                {
                    if (divingSite.GetName().ToLower().Equals(siteName.ToLower()))
                    {
                        site = divingSite;
                        break;
                    }
                }



                Console.WriteLine("Press 0 to add divers for diving Press any other key to continue : ");

                var ans = Console.ReadLine();


                if (int.TryParse(ans, out int addDiversChoice) && addDiversChoice == 0)

                {
                    Console.WriteLine("Enter the amount of divers you want to add : ");
                    int diversAmount = int.Parse(Console.ReadLine());
                    Diver[] newDiversInDive = new Diver[diversAmount];
                    int index = 0;
                    string diverName;
                    ConsoleKeyInfo cki;
                    do
                    {
                        cki = Console.ReadKey(true);
                        Console.WriteLine("Press the Escape (Esc) key to quit: \n Enter the diver name: ");
                        diverName = Console.ReadLine();

                        Diver tempDiver;
                        if (!(DiversDictionaryByName.TryGetValue(diverName, out tempDiver)))
                        {
                            Console.WriteLine("There is no diver in the name you specified\n Press any kay for exit");
                            Console.ReadKey();
                            return null;

                        }

                        newDiversInDive[index] = tempDiver;
                        index++;

                    } while (cki.Key != ConsoleKey.Escape);
                    diversInDive = newDiversInDive;
                }


                Dive dive = new Dive(divingClub, (Instructor)instructor, startTime, endTime, waterTemp, waterStatus, site, diversInDive, gears, "");

                foreach (Diver diverInDive in diversInDive)
                {
                    diverInDive.addDive(dive);
                }

                return dive;



            }

            void reRanking(Diver diver)
            {
                try
                {
                    int diverDivingAmount = diver.GetDivingDairy().GetDivesDetails().Length;
                    if (diverDivingAmount < 5)
                    {
                        Console.WriteLine("You must complete the amount of dives required for the first ranking ");
                        return;
                    }
                    else if (diverDivingAmount >= 3 && diverDivingAmount <= 5)
                    {
                        diver.UpdateRank(oneStar);
                    }
                    else if (diverDivingAmount <= 10)
                    {
                        diver.UpdateRank(twoStars);
                    }
                    else diver.UpdateRank(treeStars);

                    Console.WriteLine("Congratulations !! for your new rank ");
                }
                catch (NullReferenceException)
                {
                    Console.WriteLine("You must complete the amount of dives required for the first ranking ");
                    Console.ReadKey();
                   
                }
             
               

          



            }

            void signOnDive(Dive dive)
            {
                
               string signature;
                int len = dive.GetDivers().Length;
                object [] allSignature = new object[len];
                for (int i = 0; i < len; i++)
                {
                    Console.Write("Add your signature to the dive : ");
                    
                    allSignature[i] = Console.ReadLine();
                   
                }
                dive.SetSignature(allSignature);


            }













        }
    }































}