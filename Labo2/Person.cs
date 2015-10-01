using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public abstract class Person
    {
        public String Name{ get; set; }
        public String LastName{ get; set; }

        public Person(String name, String lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public override string ToString()
        {
            return Name + " " + LastName;
        }

        public abstract bool BirthdayWish();
    }
}
