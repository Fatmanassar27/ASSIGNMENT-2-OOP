using System.Reflection.Emit;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 2

            //Person [] person = new Person[3];
            //person[0] = new Person("Fatma",23);
            //person[1] = new Person("Toka",15);
            //person[2] = new Person("mariam",24);
            //for(int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(person[i]);
            //}

            //Person[] people = new Person[3];
            //int max = 0;
            //for (int i = 0; i < people.Length; i++)
            //{
            //    people[i].Name = Console.ReadLine();
            //    people[i].Age = int.Parse(Console.ReadLine());
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    int old = people[i].Age;
            //    max = Math.Max(old,max);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //   if(people[i].Age == max)
            //        Console.WriteLine(people[i]);
            //}
            #endregion

            #region part 3
            Emploee[] emploees = new Emploee[3];
            emploees[0] = new Emploee( Emploee.CreateEmployee(SecurityLevel.DBA) );
            emploees[1] = new Emploee( Emploee.CreateEmployee(SecurityLevel.Guest));
            emploees[2] = new Emploee( Emploee.CreateEmployee(SecurityLevel.DBA | SecurityLevel.Guest |SecurityLevel.Developer |SecurityLevel.Secretary ) );

            foreach (Emploee e in emploees)
            {
                Console.WriteLine(e);
            }


            Emploee.SortEmployees(emploees);

            foreach( Emploee e in emploees )
            {
                Console.WriteLine( e );
            }
            #endregion
        }
    }
}
