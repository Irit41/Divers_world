using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Gear
    {
         private string name;
        private string note;
        private int amount;
        public Gear(string name, int amount, string note = " ")
        {
            this.name = name;
            this.note = note;
            this.amount = amount;

        }
        public Gear(Gear obj)
        {
            this.name = obj.name;
            this.note = obj.note;
            this.amount = obj.amount;

        }

        public void SetName(string name)
        {
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetNote(string note)
        {
            this.note = note;
        }


        public string GetNote()
        {
            return this.note;
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
