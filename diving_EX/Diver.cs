using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace diving_EX
{
    class Diver 
    {

        static int diverCode = 0;

        protected string firstName;
        protected string lastName;
        protected DateTime birthDate;
        protected string userName;
        protected string password;
        protected Rank[] divingRank;
        protected Diary divingDairy;


        public Diver(string firstName, string lastName, DateTime birthDate, string userName, string password)
        {

            diverCode += 1;
            SetFirstName(firstName);
            SetLastName(lastName);
            SetBirthDate(birthDate);
            SetUserName(userName);
            SetPassword(password);

            this.divingRank = new Rank[] { };

        }

        public static int GetDiverCode()
        {
            return diverCode;
        }


        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }


        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }


        public string GetLastName()
        {
            return this.lastName;
        }




        public void SetBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }


        public DateTime GetBirthDate()
        {
            return this.birthDate;
        }


        public void SetUserName(string userName)
        {
            string Emailregex = @"^[\w\.]+@([\w-]+\.)+[\w-]{2,4}$";
            while (!Regex.IsMatch(userName, Emailregex))
            {
                Console.WriteLine("Please enter a valid email address : ");
                userName = Console.ReadLine();
            }
            this.userName = userName;
        }


        public string GetUserName()
        {
            return this.userName;
        }


        public void SetPassword(string password)
        {
            bool isValid = true;



            while (password.Length < 8)
            {
                Console.WriteLine("The password must be at least 8 characters long\n Enter a new password : ");
                password = Console.ReadLine();


            }
            password = password.Trim().ToLower();
            for (int i = 0; i < password.Length; i++)
            {
                if (!((password[i] >= 'a' && password[i] <= 'z') || !((int)password[i] >= 0 && (int)password[i] <= 9)))
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                this.password = password;
                return;
            }
            Console.WriteLine("Enter a valid password  : ");
            password = Console.ReadLine();
            SetPassword(password);




        }


        public string GetPassword()
        {
            return this.password;
        }

     


        public Rank[] GetDivingRank()
        {
            return this.divingRank;
        }







        public void SetDivingDairy(Diary divingDairy)
        {
            this.divingDairy = divingDairy;
        }

        public Diary GetDivingDairy()
        {
            return this.divingDairy;
        }




        public Rank[] UpdateRank(Rank rank)
        {
            for (int i = 0; i < divingRank.Length; i++)
            {
                if (divingRank[i] == null)
                {
                    divingRank[i] = new Rank(rank.GetName(), rank.GetInfo(), rank.GetAmount());
                    break;



                }
            }



            return divingRank;

        }
        public void addDive(Dive dive)
        {
            if (divingDairy == null )
            {
                SetDivingDairy( new Diary (new Dive[] { dive }));
              
                return;
            }

            Dive[] tempDivingDairy = divingDairy.GetDivesDetails();
            for (int i = 0; i < tempDivingDairy.Length; i++)
            {
                if (tempDivingDairy[i] == null)
                {
                    tempDivingDairy[i] = dive;
                   break;
                }
            }
            divingDairy.SetDivesDetails(tempDivingDairy);
        }

        public void scanNoteBook(Diary diary)
        {
            Dive[] diarydivesDetails = diary.GetDivesDetails();
            int curDiaryLen = divingDairy.GetDivesDetails().Length;
            foreach (Dive diaryDive in diarydivesDetails)
            {
                signTheDive(diaryDive);
            }
           
            


        }
        public void signTheDive(Dive dive)
        {
       

            Dive[] divesDetails = divingDairy.GetDivesDetails();
    
            for (int i = 0; i < divesDetails.Length; i++)
            {
                if (divesDetails[i] == null)
                {
                    divesDetails[i] = new Dive(dive);
                    divingDairy.SetDivesDetails(divesDetails);
                    break;



                }
            }



        }


    }
}
