
namespace Properties
{
    public class Person
    {

        //1. Properties shortcut prop + tab 
        //2. Constructors shortcut ctor + tab


        //auto-implemented properties
        //public string Name { get; set; }
        //public string Username { get; set; }
        public DateTime Birthdate { get; private set; }     // private set - it's read only (the birthdate can't be changed) and it's set in the constructor above

        //constructor to set the date
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }


        public int Age
        {
        // a property that calculates the person's age based on the value of another property
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }

        }
    }
}

// make sure that classes are always in a valid state 