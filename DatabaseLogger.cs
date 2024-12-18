using SolidFixed.Interfaces;
using System;

namespace SolidFixed
{
    public class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Database logger: {message}");
        }
    }
}
