using System;
using System.Diagnostics;

namespace Task3.CompareAdvancedMaths
{
    public class StopwatchMeasures
    {
        private const int TimesToExecute = 10000000;

        public static void MeasureTime(string valueType, Action method)
        {
            var stopwatch = Stopwatch.StartNew();

            for (int i = 0; i < TimesToExecute; i++)
            {
                method();
            }

            stopwatch.Stop();

            ResultsLogger.LogResult(valueType, stopwatch.Elapsed.ToString());
        }
    }
}
