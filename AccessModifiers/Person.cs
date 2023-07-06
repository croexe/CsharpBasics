using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            if(birthdate != null)
            {
                _birthdate = birthdate;
            }
        }

        public DateTime GetBirthdate()
        {
            return _birthdate;
        }
    }
}