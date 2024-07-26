using ASSIGNMENT_2_OOP.Inheritance;

namespace ASSIGNMENT_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Encapsulation
            //Employee employee = new Employee(10, "fatma", 5000, 22);
            //Console.WriteLine(employee);
            //employee.Set_Name("rawda ali");
            //Console.WriteLine(employee.Get_Name());
            //employee.Salary = 1000;
            //Console.WriteLine(employee.Salary);
            //employee.Age = 23;
            //Console.WriteLine(employee.Age);
            //Console.WriteLine(employee.deduction);
            #endregion

            #region property
            //PhoneBook p1 = new PhoneBook(3);
            //p1.addperson(0, "ahmed", 123);
            //p1.addperson(1, "ali", 456);
            //p1.addperson(2, "mohamed", 789);

            //int person_number = p1.GetPhonenumber("alaa");
            //Console.WriteLine(person_number == -1 ? "person is not found" : person_number );

            //p1.add_newnumber("ali", 999);
            //person_number = p1.GetPhonenumber("ali");

            //Console.WriteLine(person_number == -1 ? "person is not found" : person_number );

            //Console.WriteLine(p1["ali"]);
            //p1["ali"] = 111;
            //Console.WriteLine(p1["ali"]);

            //for (int i = 0; i < p1.Size; i++)
            //{
            //    Console.WriteLine(p1[i]);
            //}
            #endregion

            #region class
            //Car car = new Car();
            //Car car = new Car(1);
            //Car car2 = new Car(10,"Bmw");
            //Car car = new Car(1,"BMW",5000);
            //Console.WriteLine(car);
            //Console.WriteLine("----------------");
            //Console.WriteLine(car2);
            #endregion

            #region inheritance 
            //Parent p = new Parent(1,2);
            //Console.WriteLine(p);
            //Console.WriteLine(p.product());
            //Child c = new Child(3,4, 5);
            //Console.WriteLine(c);
            //Console.WriteLine(c.product());
            #endregion

        }
    }
}
