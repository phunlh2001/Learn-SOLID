using SolidFixed.Interfaces;

namespace SolidFixed
{
    public class Rectangle : BaseRectangle, IDimension
    {
        public void SetDimensions(double width, double height)
        {
            base.Width = width;
            base.Height = height;
        }
    }
}
