using System;
using System.IO;

namespace Task3_BARS
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\11\\Downloads\\file.txt";
            string message = "test";

            var LoggerString = new LocalFileLogger<string>(path);
            var LoggerInt = new LocalFileLogger<int>(path);

            LoggerString.LogInfo(message);
            LoggerString.LogWarning(message);
            try
            {
               throw new Exception("Проверочное исключение");
            }
            catch (Exception ex)
            {
                LoggerString.LogError(message, ex);
            }            

            LoggerInt.LogInfo(message);
            LoggerInt.LogWarning(message);
            try
            {
                throw new Exception("Проверочное исключение");
            }
            catch (Exception ex)
            {
                LoggerInt.LogError(message, ex);
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();
        }
    }
}
