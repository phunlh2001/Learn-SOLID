using SolidFixed.Interfaces;
using System;

namespace SolidFixed
{
    public class FileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"File logger: {message}");
        }
    }
}
