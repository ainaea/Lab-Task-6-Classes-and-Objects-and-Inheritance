namespace SchoolPortal
{
    public class Student
    {
        protected string RegNumber { get; set; }
        protected string Name { get; set; }
        protected string Department { get; set; }

        public Student(string rNum, string name, string dept)
        {
            RegNumber = rNum;
            Name = name;
            Department = dept;
        }
    }
}