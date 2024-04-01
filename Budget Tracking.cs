using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTPLANNER360
{
    public class Budget_Tracking
    {
        public string TYPE { get; set; }

        public int AMOUNT { get; set; }


        public Budget_Tracking(string type, int amount)
        {
            this.TYPE = type;

            this.AMOUNT = amount;

        }
    }
}
