using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Instructor : Diver 
    {
      
        private Club[] workPlaces;
        private DateTime[] startDates;
        private DateTime[] endDates;
        public Instructor(string firstName, string lastName, DateTime birthDate, string userName, string password, Rank[] divingRank, Diary divingDairy ,Club[] workPlaces, DateTime[] startDates, DateTime[] endDates) : base(firstName,lastName,birthDate, userName,password)
        {
            this.workPlaces = workPlaces;
            this.startDates = startDates;
            this.endDates =  endDates;

           










        }
        public void SetWorkPlaces(Club[] workPlaces)
        {
            this.workPlaces = workPlaces;
        }


        public Club[] GetWorkPlaces()
        {
            return this.workPlaces;
        }

        public void SetStartDates(DateTime[] startDates)
        {
            this.startDates = startDates;
        }


        public DateTime[] GetStartDates()
        {
            return this.startDates;
        }




        public void SetEndDates(DateTime[] endDates)
        {
            this.endDates = endDates;
        }


        public DateTime [] GetEndDates()
        {
            return this.endDates;
        }



    }
}
