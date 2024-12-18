using SolidFixed.Interfaces;

namespace SolidFixed
{
    internal class AreaCalculator
    {
        public double CalculateArea(IShape shape)
        {
            return shape.Area();
        }
    }
}
