using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Country
    {

        public string name;
        private string divingRegulations;

        public Country(string name, string divingRegulations)
        {
            SetName(name);
            SetDivingRegulations(divingRegulations);
        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetDivingRegulations(string divingRegulations)
        {
            this.divingRegulations = divingRegulations;
        }


        public string GetDivingRegulations()
        {
            return this.divingRegulations;
        }

     








    }
}
