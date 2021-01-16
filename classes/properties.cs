using System;

namespace Properties
{
    public class Person
    {
        public string Name { get; set; }
        // The above is a short way of defining setters and getters, notice it must be defined as public.
        public DateTime Birthdate { get; private set; }
        // By setting the setter as private, the only way you can do its function is by using a constructor.

        public Person(DateTime birthdate) 
        {
            Birthdate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;  // Obtains the time passed since the person was born.
                var years = timeSpan.Days / 365;            // Turns that time into days and divides it by the number of days per year. 

                return years;
            }
        }
    }
}