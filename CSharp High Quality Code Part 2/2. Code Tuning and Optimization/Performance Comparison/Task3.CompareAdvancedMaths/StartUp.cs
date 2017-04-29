using System;

namespace Task3.CompareAdvancedMaths
{
    public class StartUp
    {
        public static void Main()
        {
            SquareRootTest();
            NaturalLogarithmTest();
            SinusTest();
        }

        private static void SquareRootTest()
        {
            ResultsLogger.Log("Square root test");

            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
                {
                    float result = (float)Math.Sqrt(311.12534);
                });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
                {
                    double result = Math.Sqrt(311.12534);
                });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
                {
                    decimal result = (decimal)Math.Sqrt(311.12534);
                });
        }

        private static void NaturalLogarithmTest()
        {
            ResultsLogger.Log("Natural logarithm test");

            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
                {
                    float result = (float)Math.Log(311.12534);
                });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
                {
                    double result = Math.Log(311.12534);
                });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
                {
                    decimal result = (decimal)Math.Log(311.12534);
                });
        }

        private static void SinusTest()
        {
            ResultsLogger.Log("Sinus test");

            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
                {
                    float result = (float)Math.Sin(311.12534);
                });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
                {
                    double result = Math.Sin(311.12534);
                });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
                {
                    decimal result = (decimal)Math.Sin(311.12534);
                });
        }
    }
}