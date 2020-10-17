using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoleeve1
{
    class vehicle
    {
        public string Vehicle_reg;
        public double Owner_natid;
        public double Amount;
        public DateTime time;

        public string getData()
        {
            return this.Vehicle_reg + " is owned by user with I.D " + this.Owner_natid + " pays amount " + this.Amount + "/month " + " registration day " + this.time;
        }
    }

}
