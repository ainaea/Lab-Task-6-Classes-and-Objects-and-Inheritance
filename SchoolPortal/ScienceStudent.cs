namespace SchoolPortal
{
    public class ScienceStudent: Student
    {
        protected int CompNet { get; set; }
        protected int DataStruct { get; set; }
        protected int C_Sharp { get; set; }

        public ScienceStudent(string rNum, string name, string dept, int comp, int datas, int csharp) : base(rNum, name, dept)
        {
            CompNet = comp;
            DataStruct = datas;
            C_Sharp = csharp;
        }

        public override string ToString()
        {
            return $"Student {Name} with Registation Number {RegNumber} Scored {CompNet} in Computer Network, Scored {DataStruct} in Data Structure and Scored {C_Sharp} in C-Sharp. The average is {(C_Sharp + DataStruct + CompNet)/3}";
        }
    }
    
}