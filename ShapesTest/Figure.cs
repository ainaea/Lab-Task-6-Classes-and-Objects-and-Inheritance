namespace ShapesTest
{
    public class Figure
    {
        protected string Name { get; set; }
        protected double X { get; set; }
        protected double Y { get; set; }

        public Figure(string name, double x, double y)
        {
            Name = name;
            X = x;
            Y = y; 
        }

        public virtual double Area()
        {
            return X * Y;
        }

    }
}