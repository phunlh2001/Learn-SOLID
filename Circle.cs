using SolidFixed.Interfaces;
using System;

namespace SolidFixed
{
    public class Circle : IShape, IResized
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public void SetSize(double side)
        {
            Radius = side;
        }
    }
}
