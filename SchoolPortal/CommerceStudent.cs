namespace SchoolPortal
{
    public class CommerceStudent : Student
    {
        protected int ElectCir { get; set; }
        protected int CirAnaly { get; set; }
        protected int AnaCom { get; set; }

        public CommerceStudent(string rNum, string name, string dept, int electCir, int cirAnaly, int anaCom) : base(rNum, name, dept)
        {
            ElectCir = electCir;
            CirAnaly = cirAnaly;
            AnaCom = anaCom;
        }

        public override string ToString()
        {
            return $"Student {Name} with Registation Number {RegNumber} Scored {ElectCir} in Electronic Circuits, Scored {CirAnaly} in Circuit Analysis and Scored {AnaCom} in Analog Communication. The average is {(AnaCom + CirAnaly + ElectCir)/3}";
        }
    }
}