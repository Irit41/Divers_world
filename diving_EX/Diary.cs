using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diving_EX
{
    class Diary
    {
        private Dive[] divesDetails;
        public Diary(Dive[] divesDetails)
        {
            this.divesDetails = divesDetails;
        }

         public void SetDivesDetails(Dive[] divesDetails)
        {

            this.divesDetails = divesDetails;
        }
     
        public Dive[] GetDivesDetails()
        {
          return  this.divesDetails;
        }
    }
}
