using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pupil p = new Pupil("Aurelien", 18, 3);
            //Activity a1 = new Activity("math", true);
            //Activity a2 = new Activity("anglais", false);
            //Activity a3 = new Activity("francais", true);

            //p.AddActivity(a1);
            //p.AddActivity(a2);
            //p.AddActivity(a3);

            //p.AddEvaluation(a1.Title);
            //p.AddEvaluation(evaluation: 'T', title: "anglais");
            //p.AddEvaluation("francais", 'R');

            //List<Pupil> pupils = new List<Pupil>() {
            //    new Pupil("quentin", 12, 5),
            //    new Pupil("kevin", 7 , 1),
            //    new Pupil("maxime", 3, 2)
            //};

            

            //var pupilGrade1Plus6 = from pupil in pupils
            //                       where pupil.Grade == 1 && pupil.Age > 6
            //                       select pupil;

            //List<Pupil> pupils = new List<Pupil>();

            //pupils.Add(new Pupil("kevin", 7, 1));
            //pupils.Add(new Pupil("cedric", 5, 2));
            //pupils.Add(new Pupil("quentin", 8, 4));

            //var pupilGrade1Plus6 = pupils.FindAll(p => p.Grade == 1);

            //Console.Write(p);

            //if (pupilGrade1Plus6 != null)
            //{
            //    foreach (var pupil in pupilGrade1Plus6)
            //    {
            //        Console.Write(pupil);
            //    }
            //}
            //else
            //{
            //    Console.Write("test");
            //}

            //List<Pupil> listPupils = new List<Pupil>() {
            //    new Pupil("quentin", 12, 4),
            //    new Pupil("kevin", 7 , 1),
            //    new Pupil("maxime", 3, 7)

            //};

            //List<Person> listPersons = new List<Person>() {
            //    new Person("azeaze", 12),
            //    new Person("azerr", 7 ),
            //    new Person("ffdfsdf", 3)
            //};

            //var listFusion = listPersons.Union(listPupils);

            //foreach (var item in listFusion)
            //{
            //    Console.Write(item);
            //}

            //List<Pupil> listPupilsDuplicated = new List<Pupil>() {
            //    new Pupil("quentin", 12, 4),
            //    new Pupil("kevin", 7 , 1),
            //    new Pupil("maxime", 3, 7),
            //    new Pupil("quentin", 12, 4),
            //    new Pupil("kevin", 7 , 1),
            //    new Pupil("maxime", 3, 7)
            //};

            //IEnumerable<Pupil> listPupilsNoDuplicated = listPupilsDuplicated.Distinct<Pupil>(new PersonComparer());

            //Console.Write(listPupilsNoDuplicated.Count());

            //===LABO 2

            Pupil pupilActComp = new Pupil("quentin", 18);
            Activity a1 = new Activity("math", true);
            Activity a2 = new Activity("anglais", false);
            Activity a3 = new Activity("francais", true);

            pupilActComp.AddActivity(a1);
            pupilActComp.AddActivity(a2);
            pupilActComp.AddActivity(a3);


            //Console.WriteLine(pupilActComp.PrintPupilActivityCompulsory(
            //    delegate(Activity activity)
            //    {
            //        return activity.Title + "\n";
            //    }));

            //Console.WriteLine(pupilActComp.PrintPupilActivityCompulsory(PrintActivity));

            PrintActivityDelegate p = new PrintActivityDelegate();
            Console.WriteLine(pupilActComp.PrintPupilActivityCompulsory(p.PrintActivity));

            Object obj = 10;

            obj = (int)obj + 10;
            Console.WriteLine(obj);

            Console.Read();
        }

        private static string PrintActivity(Activity activity)
        {
            return activity.Title + "\n";
        }
    }
}
