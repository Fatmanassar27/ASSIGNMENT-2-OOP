namespace ASSIGNMENT_2_OOP.Encapsolation
{
    internal struct Employee
    {
        //public int Id;
        //private string? Name;
        //private decimal salary;
        //private int? age;

        #region constractor
        //public Employee(int id, string? name, decimal salary, int age)

        //{
        //    Id = id;
        //    Name = name;
        //    this.salary = salary;
        //    this.age = age;
        //}

        #endregion

        #region method
        //public override string? ToString()
        //{
        //    return $"Name = {Name} \nID = {Id} \nSalary = {salary}\nAge = {age}";
        //}

        //#endregion

        //#region setter and getter function 
        //public void Set_Name(string? name)
        //{
        //    Name = name.Length > 5 ? name.Substring(0, 5) : name;
        //}
        //public string? Get_Name()
        //{
        //    return Name;
        //}
        //#endregion

        //#region encapsulation using property

        // full property 
        //public decimal Salary
        //{

        //    get
        //    {
        //        return salary;
        //    }
        //    set
        //    {
        //        salary = value < 3000 ? 3000 : value;
        //    }

        //}

        // automatic property

        //public int? Age { get; set; }

        //Deduction
        //public decimal deduction
        //{
        //    get { return (salary * 0.2M); }
        //}
        #endregion


    }
}
