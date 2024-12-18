using System;

namespace SolidFixed
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine($"Area of Rectangle before change: {rect.Area()}");

            rect.SetDimensions(2, 3);
            Console.WriteLine($"Area of Rectangle after change: {rect.Area()}");

            Console.WriteLine("========== SQUARE ==========");

            var square = new Square { Side = 3 };
            Console.WriteLine($"Area of Square before resize: {square.Area()}");

            square.SetSize(4);
            Console.WriteLine($"Area of Square after resized: {square.Area()}");

            Console.WriteLine("========== CIRCLE ==========");

            var circle = new Circle { Radius = 1 };
            Console.WriteLine($"Area of Circle before resize: {circle.Area()}");

            circle.SetSize(2);
            Console.WriteLine($"Area of Square after resized: {circle.Area()}");

            Console.WriteLine("========== Logger ==========");
            var fileLogger = new FileLogger();
            fileLogger.Log("Hello World!");

            var dbLogger = new DatabaseLogger();
            dbLogger.Log("Hi Mom!");
        }
    }
}
