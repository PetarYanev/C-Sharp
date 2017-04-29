using System;

namespace Task2.CompareSimpleMaths
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
