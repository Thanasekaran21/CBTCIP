using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVENTPLANNER360
{
   public class Detailsclass
    {
       public string City { get; set; }

       public string Venues { get; set;}

       public string Strength { get; set; }

       public Detailsclass(string city, string venues , string strength)
       {
           this.City = city;

           this.Venues = venues;

           this.Strength = strength;

       }

    }
}
