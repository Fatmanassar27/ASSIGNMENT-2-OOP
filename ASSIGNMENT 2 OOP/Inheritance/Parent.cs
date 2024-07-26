namespace ASSIGNMENT_2_OOP.Inheritance
{
    internal class Parent
    {
        //property
        public int X { get; set; }
        public int Y { get; set; }

        //override
        public override string ToString()
        {
            return $"({X} , {Y})";
        }
        //constructor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
        }
        //object member method
        public int product()
        {
            return X * Y;
        }
    }
}
