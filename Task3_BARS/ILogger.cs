using System;
using System.Collections.Generic;
using System.Text;

namespace Task3_BARS
{
    interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message, Exception ex);
    }
}
