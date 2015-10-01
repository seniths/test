using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    public class Pupil : Person
    {
        public delegate string DelegatePrintActivityCompulsory(Activity activity);

        public int Grade { get; set; }

        public List<Activity> LstActivities
        {
            get;
            set;
        }

        //public Parameter.Evaluation[] PupilEvaluations { get; set; }

        //private Dictionary<String, char> pupilActivities = new Dictionary<string, char>();

        //public Dictionary<String, char> PupilActivities
        //{
        //    get { return pupilActivities; }
        //    set { pupilActivities = value; }
        //}


        public Pupil(String name, int age, int grade)
            : base(name, age)
        {
            Grade = grade;
            LstActivities = new List<Activity>();
            //PupilEvaluations = new Parameter.Evaluation[Parameter.MAX];
        }

        public Pupil(String name, int age)
            : this(name, age, 1)
        {

        }

        public void AddActivity(Activity a)
        {
            LstActivities.Add(a);
            //PupilActivities.Add(t, '0');
        }

        public override string ToString()
        {
            string ch = Header();

            ch = PrintActivities(ch);
            //ch = PrintCourses(ch);

            return ch;
        }

        private string PrintActivities(string ch)
        {
            for (int i = 0; i < LstActivities.Count(); i++)
            {
                ch += LstActivities[i] + "\n";
            }
            return ch;
        }

        private string Header()
        {
            //string ch = base.ToString() + ((PupilActivities.Count() != 0) ? " a choisi les activités suivantes:\n" : " n'a pas d'activité");
            string ch = base.ToString() + ((LstActivities.Count() != 0) ? " a choisi les activités suivantes:\n" : " n'a pas d'activité");
            return ch;
        }

        //public void AddEvaluation(String title, char evaluation = 'S')
        //{
        //    int i = 0;
        //    if (title != null)
        //    {
        //        foreach (Activity activity in LstActivities)
        //        {
        //            if (activity.Title.Equals(title)) break;
        //            i++;
        //        }
        //        PupilEvaluations[i] = evaluation;
        //    }

        //    //if (title != null)
        //    //    PupilActivities[title] = evaluation;
        //}

        //private string PrintCourses(string ch)
        //{
        //    int i;
        //    for (i = 0; i < PupilActivities.Count(); i++)
        //        ch += "\n" + PupilActivities.ElementAt(i).Key.ToString() + " : " +
        //        PupilActivities.ElementAt(i).Value;
        //    return ch;
        //}

        public string PrintPupilActivityCompulsory(DelegatePrintActivityCompulsory MyPrintActivity)
        {
            int numActivity = 0;
            string ch = base.ToString() + " a choisi les activités obligatoires : \n";
            foreach (Activity activity in LstActivities)
                if (activity.Compulsory)
                    ch += (++numActivity) + " " + MyPrintActivity(activity);
            return ch;
        }
    }


}
