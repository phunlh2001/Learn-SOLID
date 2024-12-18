namespace SolidFixed
{
    // Single Responsibility Principle (S) Violation
    public class Logger
    {
        public void LogToFile(string message)
        {
            // Log to a file
        }

        public void LogToDatabase(string message)
        {
            // Log to a database
        }
    }
}
