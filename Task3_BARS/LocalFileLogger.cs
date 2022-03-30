using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Task3_BARS
{
    public class LocalFileLogger<T> : ILogger
    {
        public string Path { get; set; }
       
        public LocalFileLogger(string path)
        {
            Path = path;
            if (!File.Exists(path))
            {
                using StreamWriter file = File.CreateText(path);
            }
        }

        public void LogInfo(string message) 
        {
            File.AppendAllText(Path, $"[Info]: [{typeof(T).Name}] : {message}{Environment.NewLine}");
        }
        public void LogWarning(string message) 
        {
            File.AppendAllText(Path, $"[Warning] : [{typeof(T).Name}] : {message}{Environment.NewLine}");
        }
        public void LogError(string message, Exception ex) 
        {
            File.AppendAllText(Path, $"[Error] : [{typeof(T).Name}] : {message}. {ex.Message}{Environment.NewLine}");
        }
    }
}
