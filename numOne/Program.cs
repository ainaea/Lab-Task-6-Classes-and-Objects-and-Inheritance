using System;

namespace numOne
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Rectangle rec1 = new Rectangle(2,3);
            Console.WriteLine($"Perimeter {rec1.Perimeter} Area {rec1.Area}");
        }
    }
}
