using System;

namespace GMDemo.Logger
{
    public class Logger : ILogger
    {
        public void Log(Exception msg)
        {
            Console.WriteLine("Error: " + msg.Message);
        }
    }
}