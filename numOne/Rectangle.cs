namespace numOne
{
    public class Rectangle
    {
        // public float RecLength { get; set; }    
        // public float RecWidth { get; set; }
        private float recLength = 1;
        private float recWidth = 1;


        public Rectangle(float rLength, float rWidth)
        {
            RecLength = rLength;
            RecWidth = rWidth;
        }

        private float RecLength
        {
            get { return recLength; }
            set {
                    if (value > 0 && value < 20)
                    {
                    recLength = value;                         
                    }
                }
        }

        private float RecWidth
        {
            get { return recWidth; }
            set {
                    if (value > 0 && value < 20)
                    {
                    recWidth = value;                         
                    }
                }
        }

        public float Perimeter
        {
            get { return 2 * (RecWidth + RecLength); }
        }

        public float Area
        {
            get { return RecWidth * RecLength; }
        }
        
    }
}