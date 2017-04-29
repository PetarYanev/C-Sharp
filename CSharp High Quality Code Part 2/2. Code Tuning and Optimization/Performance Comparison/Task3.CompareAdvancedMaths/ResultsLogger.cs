using System;

namespace Task3.CompareAdvancedMaths
{
    public class ResultsLogger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void LogResult(string valueType, string time)
        {
            Console.WriteLine($"{valueType} for result time : {time}");
        }
    }
}
