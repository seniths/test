using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrivateContact quentin = new PrivateContact("quentin", "miroult", "1234", "azeaz@aze.com");
            //PrivateContact chris = new PrivateContact("chris", "desplentere", "456", "azeaz@aze.com", DateTime.Today);


            //Console.WriteLine(quentin);
            //Console.WriteLine(chris);


            ProfessionalContact kevin = new ProfessionalContact("kevin", "willot", "Consultant", "3256", "aaze@a.com");
            ProfessionalContact kev2 = new ProfessionalContact("kev2", "consult", "Consultant", "3256", "mm@a.com");
            ProfessionalContact kev3 = new ProfessionalContact("kev3", "test", "Independant", "3256", "fff@a.com");

            Enterprise belgacom = new Enterprise("Belgacom", "Bxl");
            Enterprise sncb = new Enterprise("SNCB", "Namur");

            kevin.EnterpriseAdd(belgacom);
            kevin.EnterpriseAdd(sncb);
            kev2.EnterpriseAdd(belgacom);

            List<ProfessionalContact> lstProf = new List<ProfessionalContact>();
            lstProf.Add(kevin);
            lstProf.Add(kev2);
            lstProf.Add(kev3);

            var lstIndep = from prof in lstProf
                           where prof.Profession.Equals("Independant")
                           select prof;

            Console.WriteLine(lstIndep.Count());

            var lstConsult = lstProf.FindAll(n => n.Profession.Equals("Consultant") && n.LstEnterprises.Contains(belgacom));

            if (lstConsult != null)
            {
                foreach (var item in lstConsult)
                {
                    Console.WriteLine(item);
                }
            }

            Console.Read();
        }
    }
}
