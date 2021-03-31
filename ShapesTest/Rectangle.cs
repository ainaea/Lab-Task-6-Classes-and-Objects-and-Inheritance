namespace ShapesTest
{
    public class Rectangle : Figure
    {
        public Rectangle(double x, double y) : base("Rectangle", x, y)
        {   }

        public override double Area()
        {
            return X * Y;
        }
    
    }
}