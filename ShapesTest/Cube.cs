namespace ShapesTest
{
    public class Cube : Figure
    {
        public Cube(double x) : base("Cube", x,x)
        {   }

        public override double Area()
        {
            return X * X * 6;
        }
    }
}