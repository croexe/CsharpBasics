using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Person
    {
      //  private DateTime _birthdate;
     /*   public DateTime Birthdate 
        { 
            get { return _birthdate }
            set { _birthdate = value; } 
            }  */
        public DateTime Birthdate { get; set; }

        public int Age 
        {
            get 
            { 
                var timespan = DateTime.Today - Birthdate;
                var years = timespan.Days / 365;
                return years;
            } 
        }
    }
}
