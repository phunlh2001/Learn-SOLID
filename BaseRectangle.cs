using SolidFixed.Interfaces;

namespace SolidFixed
{
    public class BaseRectangle : IShape
    {
        public virtual double Width { get; set; }
        public virtual double Height { get; set; }
        public double Area()
        {
            return Width * Height;
        }
    }
}
