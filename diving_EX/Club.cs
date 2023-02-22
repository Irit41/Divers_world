using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Club
    {
        private int id;
        private string name;
        private Country country;
        private string contact;
        private string city;
        private string street;
        private string phoneNumber;
        private string email;
        private string website;
        public Club(int id, string name, Country country, string contact, string city, string street, string phoneNumber, string email, string website = " ")
        {
            this.id = id;
            this.name = name;
            this.country = country;
            this.contact = contact;
            this.city = city;
            this.street = street;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.website = website;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetName(string name)
        {
            this.name = name;
        }


        public string GetName()
        {
            return this.name;
        }



        public void SetContact(string contact)
        {
            this.contact = contact;
        }


        public string GetContact()
        {
            return this.contact;
        }

        public void SetCity(string city)
        {
            this.city = city;
        }


        public string GetCity()
        {
            return this.city;
        }




        public void SetStreet(string street)
        {
            this.street = street;
        }


        public string GetStreet()
        {
            return this.street;
        }










        public void SetCountry(Country country)
        {
            this.country = country;
        }


        public Country GetCountry()
        {
            return this.country;
        }






        public void SetPhoneNumber(string phoneNumber)
        {
            this.phoneNumber = phoneNumber;
        }


        public string GetPhoneNumber()
        {
            return this.phoneNumber;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }


        public string GetEmail()
        {
            return this.email;
        }




        public void SetWebsite(string website)
        {
            this.website = website;
        }


        public string GetWebsite()
        {
            return this.website;
        }


        public override string ToString()
        {
            string str = $@"{name}
{website}
Adress  :  {country.GetName()},{city},{street} 
Contact Us
Our contact : {contact} - {phoneNumber}
{email}";
            return str;
        }






    }
}
