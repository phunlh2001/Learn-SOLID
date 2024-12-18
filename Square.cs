using SolidFixed.Interfaces;

namespace SolidFixed
{
    public class Square : IShape, IResized
    {
        public double Side { get; set; }

        public double Area()
        {
            return Side * Side;
        }

        public void SetSize(double side)
        {
            Side = side;
        }
    }
}
