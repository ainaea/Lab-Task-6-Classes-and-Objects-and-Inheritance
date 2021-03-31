namespace ShapesTest
{
    public class Square : Figure
    {
        public Square(double x) : base("Square", x, x)
        {   }

        public override double Area()
        {
            return X * X ;
        }
    }
}