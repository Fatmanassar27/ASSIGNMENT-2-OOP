using ASSIGNMENT_2_OOP.Encapsolation;

namespace ASSIGNMENT_2_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee(10, "fatma", 5000, 22);
            Console.WriteLine(employee);
            employee.Set_Name("rawda ali");
            Console.WriteLine(employee.Get_Name());
            employee.Salary = 1000;
            Console.WriteLine(employee.Salary);
            employee.Age = 23;
            Console.WriteLine(employee.Age);
            Console.WriteLine(employee.deduction);
        }
    }
}
