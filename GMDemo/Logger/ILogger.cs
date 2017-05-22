using System;

namespace GMDemo.Logger
{
    public interface ILogger
    {
        void Log(Exception msg);
    }
}