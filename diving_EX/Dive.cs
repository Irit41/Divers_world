using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Dive
    {



        private Club divingClub;
        private Instructor divingInstructor;
        private DateTime startTime;
        private DateTime endTime;
        private double waterTemp;
        private string waterStatus;
        private DivingSite site;
       private Diver[] divers;
       private Gear[] gears;
        private object signature;

        public Dive(Club divingClub, Instructor divingInstructor, DateTime startTime, DateTime endTime, double waterTemp, string waterStatus, DivingSite site, Diver[] divers, Gear[] gears, object signature)
        {
            SetDivingClub(divingClub);
            SetDivingInstructor(divingInstructor);
            SetStartTime(startTime);
            SetEndtTime(endTime);
            SetWaterTemp(waterTemp);
            SetWaterStatus(waterStatus);
            SetSite(site);
            SetDivers(divers);
            SetGears(gears);
            SetSignature(signature);

        }
        public Dive(Dive dive)
        {
            SetDivingClub(dive.divingClub);
            SetDivingInstructor(dive.divingInstructor);
            SetStartTime(dive.startTime);
            SetEndtTime(dive.endTime);
            SetWaterTemp(dive.waterTemp);
            SetWaterStatus(dive.waterStatus);
            SetSite(dive.site);
            SetDivers(dive.divers);
            SetGears(dive.gears);
            SetSignature(dive.signature);

        }

        public void SetDivingClub(Club divingClub)
        {
            this.divingClub = divingClub;
        }


        public Club GetDivingClub()
        {
            return this.divingClub;
        }

        public void SetDivingInstructor(Instructor divingInstructor)
        {
            this.divingInstructor = divingInstructor;
        }


        public Instructor GetDivingInstructor()
        {
            return this.divingInstructor;
        }

        public void SetStartTime(DateTime startTime)
        {
            this.startTime = startTime;
        }


        public DateTime GetStartTime()
        {
            return this.startTime;
        }



        public void SetEndtTime(DateTime endTime)
        {
            this.endTime = startTime;
        }


        public DateTime GetEndTime()
        {
            return this.endTime;
        }
        public void SetWaterTemp(double waterTemp)
        {
            this.waterTemp = waterTemp;
        }


        public double GetWaterTemp()
        {
            return this.waterTemp;
        }

        public void SetWaterStatus(string waterStatus)
        {
            this.waterStatus = waterStatus;
        }


        public string GetWaterStatus()
        {
            return this.waterStatus;
        }
        public void SetSite(DivingSite site)
        {
            this.site = site;
        }


        public DivingSite GetSite()
        {
            return this.site;
        }

        public void SetDivers(Diver[] divers)
        {
            this.divers = divers;
        }


        public Diver[] GetDivers()
        {
            return this.divers;
        }
        public void SetGears(Gear[] gears)
        {
            this.gears = gears;
        }


        public Gear[] GetGears()
        {
            return this.gears;
        }


        public void SetSignature(object signature)
        {
            this.signature = signature;
        }


        public object GetSignature()
        {
            return this.signature;
        }


    }
}
