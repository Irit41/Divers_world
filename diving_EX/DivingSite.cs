using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class DivingSite
    {

        private string name;
        private Country country;
        private string address;
        private string info;
        private double depth;
        private double length;
        private string waterType;
        public DivingSite(string name, Country country, string address, string info, double depth, double length, string waterType)
        {
            SetName(name);
            SetCountry(country);
            SetAddress(address);
            SetInfo(info);
            SetDepth(depth);
            SetLength(length);
            SetWaterType(waterType);
        }


        public void SetName(string name)
        {
            this.name = name;
        }


        public string GetName()
        {
            return this.name;
        }

        public void SetCountry(Country country)
        {
            this.country = country;
        }


        public Country GetCountry()
        {
            return this.country;
        }





        public void SetAddress(string address)
        {
            this.address = address;
        }


        public string GetAddress()
        {
            return this.address;
        }

        public void SetInfo(string info)
        {
            this.info = info;
        }


        public string GetInfo()
        {
            return this.info;
        }




        public void SetWaterType(string waterType)
        {
            this.waterType = waterType;
        }


        public string GetWaterType()
        {
            return this.waterType;
        }


        public void SetDepth(double depth)
        {
            this.depth = depth;
        }


        public double GetDepth()
        {
            return this.depth;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }


        public double GetLength()
        {
            return this.length;
        }




    }
}
