using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Rank
    {

        private string name;
        private string info;
        private int amount;
        public Rank(string name, string info, int amount)
        {
            SetName(name);
            SetInfo(info);
            SetAmount(amount);

        }


        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetInfo(string info)
        {
            this.info = info;
        }


        public string GetInfo()
        {
            return this.info;
        }

        public void SetAmount(int amount)
        {
            this.amount = amount;

        }


        public int GetAmount()
        {
            return this.amount;
        }







    }
}
