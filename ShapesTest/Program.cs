using System;

namespace ShapesTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            GetFigure();
        }

        static void GetFigure()
        {
            int choice;
            while (true)
            {
                Console.WriteLine("Enter the number corresponding to the shape you want to work with\n1 for Rectangle\n2 for Triangle\n3 for Square\n4 for Cube ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice > 0 || choice < 5)
                {
                    break;
                }
            }

            double len; double width;
            switch (choice)
            {
                case 1:
                while (true)
                {
                    Console.WriteLine("Enter length of the rectangle: ");
                    len = Convert.ToInt32(Console.ReadLine());
                    if (len > 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter width of the rectangle: ");
                    width = Convert.ToInt32(Console.ReadLine());
                    if (width > 0)
                    {
                        break;
                    }
                }
                Rectangle rect = new Rectangle(len, width);
                Console.WriteLine($"Area is {rect.Area()}");
                break;

                case 2:
                while (true)
                {
                    Console.WriteLine("Enter base of the triangle: ");
                    len = Convert.ToInt32(Console.ReadLine());
                    if (len > 0)
                    {
                        break;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter height of the triangle: ");
                    width = Convert.ToInt32(Console.ReadLine());
                    if (width > 0)
                    {
                        break;
                    }
                }
                Triangle triangle = new Triangle(len, width);
                Console.WriteLine($"Area is {triangle.Area()}");
                break;

                case 3:
                while (true)
                {
                    Console.WriteLine("Enter length of the square: ");
                    len = Convert.ToInt32(Console.ReadLine());
                    if (len > 0)
                    {
                        break;
                    }
                }
                Square square = new Square(len);
                Console.WriteLine($"Area is {square.Area()}");

                break;

                case 4:
                while (true)
                {
                    Console.WriteLine("Enter length of the cube: ");
                    len = Convert.ToInt32(Console.ReadLine());
                    if (len > 0)
                    {
                        break;
                    }
                }
                Cube cube = new Cube(len);
                Console.WriteLine($"Area is {cube.Area()}");
                break;

                default:
                break;
            }
        }

    }
}
