using System;

namespace Solution
{
    class Rectangle : IShape
    {
        public double Height { get; set; }  
        public double Width { get; set; }

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            return Height * Width;
        }
    }
}
