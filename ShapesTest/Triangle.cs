namespace ShapesTest
{
    public class Triangle : Figure
    {
        public Triangle(double x, double y) : base("Triangle", x, y) 
        {   }

        public override double Area()
        {
            return X * Y * 0.5;
        }
    }
}