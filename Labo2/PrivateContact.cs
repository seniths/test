using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class PrivateContact: Person
    {
        public String PhoneNumber { get; set; }
        public String Mail { get; set; }
        public DateTime BirthDay { get; set; }

        public PrivateContact(String name, String lastName, String phone, String mail, DateTime bday)
            : this(name, lastName, phone, mail)
        {
            BirthDay = bday;
        }

        public PrivateContact(String name, String lastName, String phone, String mail)
            : base(name, lastName)
        {
            PhoneNumber = phone;
            Mail = mail;
        }

        public override string ToString()
        {
            return base.ToString() + " " + PhoneNumber + ((BirthdayWish()?"\nBon anniversaire":""));
        }

        public override bool BirthdayWish()
        {
            return (DateTime.Today.Month == BirthDay.Month && DateTime.Today.Day == BirthDay.Day);
        }
    }
}
