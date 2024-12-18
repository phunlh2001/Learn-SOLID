using System;

namespace SolidFixed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fileCalculate = new AreaCalculatorWithLogger(new FileLogger());
            var dbCalculate = new AreaCalculatorWithLogger(new DatabaseLogger());
            /**
             * rect 1x4=4
             * rect.SetDimensions(2,3) => 6
             * 
             * square 3x3=9
             * square.SetSize(4) => 16
             * 
             * circle 1^2xPI=3.14...
             * circle.SetSize(2) => 12....
             */

            Console.WriteLine("========== RECTANGLE ==========");
            var rect = new Rectangle { Height = 1, Width = 4 };
            Console.WriteLine("- Area of Rectangle before change:");
            fileCalculate.CalculateArea(rect);


            rect.SetDimensions(2, 3);
            Console.WriteLine("- Area of Rectangle after change:");
            dbCalculate.CalculateArea(rect);

            Console.WriteLine("========== SQUARE ==========");

            var square = new Square { Side = 3 };
            Console.WriteLine($"- Area of Square before resize:");
            fileCalculate.CalculateArea(square);

            square.SetSize(4);
            Console.WriteLine($"- Area of Square after resized:");
            dbCalculate.CalculateArea(square);

            Console.WriteLine("========== CIRCLE ==========");

            var circle = new Circle { Radius = 1 };
            Console.WriteLine($"- Area of Circle before resize:");
            fileCalculate.CalculateArea(circle);

            circle.SetSize(2);
            Console.WriteLine($"- Area of Square after resized:");
            dbCalculate.CalculateArea(circle); ;
        }
    }
}
