using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    public enum Gender
    {
       F,
       M
    }
    [Flags]
    public enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,    
    }
    internal class Emploee
    {
        #region Design and implement a Class for the employees in a company:
         
        // property
        public int ID {  get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }  
        public SecurityLevel Security_level {  get; set; }
        public Hiring_Date Hire_date { get; set; }
        public Gender Gender;


        // constructor
        public Emploee(int iD, string name, int salary, SecurityLevel security_level, Hiring_Date hire_date, Gender gender)
        {
            ID = iD;
            Name = name;
            Salary = salary;
            Security_level = security_level;
            Hire_date = hire_date;
            Gender = gender;
        }

        public Emploee()
        {

        }

        public Emploee(Emploee employee)
        {
            ID = employee.ID;
            Name = employee.Name;
            Salary = employee.Salary;
            Security_level = employee.Security_level;
            Hire_date = employee.Hire_date;
            Gender = employee.Gender;
        }
        // override
        public override string ToString()
        {
            return $"ID : {ID}\nName : {Name}\nsecurity level : {Security_level}\nsalary : {Salary:C}\nHiring Date : {Hire_date}\nGender : {Gender}";
        }

        public static Emploee CreateEmployee(SecurityLevel security)
        {
            Emploee employee = new Emploee();
            string? input;
            int id;
            do
            {
                Console.Write("Enter Employee ID : ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out id));
            employee.ID = id;

            Console.Write("Enter Employee Name : ");
            employee.Name = Console.ReadLine();


            int salary;
            do
            {
                Console.Write("Enter Employee Salary: ");
                input = Console.ReadLine();
            }
            while (!int.TryParse(input, out salary));
            employee.Salary = salary;
            
            employee.Security_level = security;

            employee.Hire_date = Hiring_Date.CreateHiringDate();

            Gender G;
            do
            {
                Console.Write("Enter Employee Gender : ");
                input = Console.ReadLine();
            }
            while (!Gender.TryParse(input, out G));
            employee.Gender = G;


            return employee;
        }

        public static Emploee [] SortEmployees (Emploee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                int it = i ;
                for(int j = i+1 ; j < employees.Length; j++)
                {
                    if (Hiring_Date.CompareHiringDate( employees[j].Hire_date , employees[it].Hire_date ) )
                    {
                        it = j ;
                    }

                    if (it != i)
                    {
                       Emploee temp = new Emploee  (employees[i]);
                       employees[i] = new Emploee  (employees[it]);
                       employees[it] = new Emploee  (temp);
                    }
                }
            }
            return employees;
        }
        #endregion
    }
}
