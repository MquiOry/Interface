using System;


namespace Solution
{
    class Circle : IShape
    {
        public double Radius { get; set; }  

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return 3.14 * Math.Pow(Radius, 2);
        }
    }
}
