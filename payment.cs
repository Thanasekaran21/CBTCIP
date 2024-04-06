using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTPLANNER360
{
     public class payment
    {
         public string paymentmethod { get; set; }


         public payment(string payment)
         {
             this.paymentmethod = payment;
         }
    }
}
