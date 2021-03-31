using System;

namespace SchoolPortal
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            GetData();
        }

        static void GetData()
        {
            Console.WriteLine("Registration Number");
            string reg = Console.ReadLine();

            Console.WriteLine("Name");
            string name = Console.ReadLine();

            string dept;
            while (true)
            {
                Console.WriteLine("Enter 'SCI' for Computer Science or 'COM' for Commercial ");
                dept = Console.ReadLine();
                if (dept == "SCI" || dept == "COM")
                {
                    break;
                }
            }

            int num1; int num2; int num3;
            if (dept == "SCI")
            {
                Console.WriteLine("Enter score in Computer Network ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter score in Data Structure ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter score in C - Sharp ");
                num3 = Convert.ToInt32(Console.ReadLine());
            }else
            {
                Console.WriteLine("Enter score in Electronic Circuits ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter score in Circuit Analysis ");
                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter score in Analog Communication ");
                num3 = Convert.ToInt32(Console.ReadLine());
            }

            if (dept == "SCI")
            {
                ScienceStudent newStudent = new ScienceStudent(reg, name, "Science", num1, num2, num3) ;
                Console.WriteLine(newStudent);
            }else
            {
                CommerceStudent newStudent = new CommerceStudent(reg, name, "Commercial", num1, num2, num3) ;
                Console.WriteLine(newStudent);
            }
            

        }
    }
}
