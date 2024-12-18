using SolidFixed.Interfaces;

namespace SolidFixed
{
    public class AreaCalculatorWithLogger
    {
        private readonly ILogger _logger;
        public AreaCalculatorWithLogger(ILogger logger)
        {
            _logger = logger;
        }

        public double CalculateArea(IShape shape)
        {
            var area = shape.Area();

            // Violates Dependency Inversion Principle
            // The high-level module (AreaCalculatorWithLogger) depends on a low-level module (Logger).
            // Both should depend on abstractions.
            _logger.Log($"Calculated area: {area}");
            return area;
        }
    }
}
