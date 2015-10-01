using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    public class ProfessionalContact: Person
    {
        public String Profession { get; set; }
        public String ProfessionalPhone { get; set; }
        public String ProfessionalMail { get; set; }
        public List<Enterprise> LstEnterprises { get; set; }

        public ProfessionalContact(String name, String lastName, String profession, String profPhone, String profMail)
            : base(name, lastName)
        {
            Profession = profession;
            ProfessionalPhone = profPhone;
            ProfessionalMail = profMail;
            LstEnterprises = new List<Enterprise>();
        }

        public override string ToString()
        {
            return base.ToString() + " (" + ProfessionalPhone +")\n" + Profession + "\n" + ProfessionalMail;
        }

        public override bool BirthdayWish()
        {
            return false;
        }

        public void EnterpriseAdd(Enterprise e)
        {
            LstEnterprises.Add(e);
        }
    }
}
