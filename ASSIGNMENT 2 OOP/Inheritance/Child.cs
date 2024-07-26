namespace ASSIGNMENT_2_OOP.Inheritance
{
    internal class Child : Parent
    {
        public int Z { get; set; }
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }
        public override string ToString()
        {
            return $"({X} , {Y} , {Z} )";
        }

        public new int product()
        {
            return X * Y * Z;
        }
    }
}
