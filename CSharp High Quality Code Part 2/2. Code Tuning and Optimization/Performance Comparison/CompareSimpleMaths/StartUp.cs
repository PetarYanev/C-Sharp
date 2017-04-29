namespace Task2.CompareSimpleMaths
{
    public class StartUp
    {
        public static void Main()
        {
            AddTest();
            SubtractTest();
            IncrementTest();
            MultiplyTest();
            DivideTest();
        }

        private static void AddTest()
        {
            ResultsLogger.Log("Add test");

            StopwatchMeasures.MeasureTime(
                "Int",
                () =>
            {
                int result = 44243 + 14242;
            });

            StopwatchMeasures.MeasureTime(
                "Long",
                () =>
            {
                long result = 32233720368547758 + 56757514242;
            });

            StopwatchMeasures.MeasureTime(
                "Float", 
                () =>
            {
                float result = 311.125345f + 14242.643256f;
            });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
            {
                double result = 324.23425235d + 234.324254534d;
            });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
            {
                decimal result = 324.2433425235m + 234.35354254534m;
            });
        }

        private static void SubtractTest()
        {
            ResultsLogger.Log("Subtract test");

            StopwatchMeasures.MeasureTime(
                "Int",
                () =>
            {
                int result = 44243 - 14242;
            });

            StopwatchMeasures.MeasureTime(
                "Long",
                () =>
            {
                long result = 32233720368547758 - 56757514242;
            });

            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
            {
                float result = 311.125345f - 14242.643256f;
            });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
            {
                double result = 324.23425235d - 234.324254534d;
            });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
            {
                decimal result = 324.2433425235m - 234.35354254534m;
            });
        }

        private static void IncrementTest()
        {
            ResultsLogger.Log("Increment test");

            int intResult = 0;
            StopwatchMeasures.MeasureTime(
                "Int",
                () =>
            {
                intResult++;
            });

            long longResult = 0;
            StopwatchMeasures.MeasureTime(
                "Long",
                () =>
            {
                longResult++;
            });

            float floatResult = 1.1f;
            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
            {
                floatResult++;
            });

            double doubleResult = 1.1d;
            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
            {
                doubleResult++;
            });

            decimal decimalResult = 1.1m;
            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
            {
                decimalResult++;
            });
        }

        private static void MultiplyTest()
        {
            ResultsLogger.Log("Multiply test");

            StopwatchMeasures.MeasureTime(
                "Int",
                () =>
            {
                int result = 442 * 142;
            });

            StopwatchMeasures.MeasureTime(
                "Long",
                () =>
            {
                long result = 68548 * 6442;
            });

            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
            {
                float result = 311.1253f * 14242.6456f;
            });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
            {
                double result = 324.23235d * 234.3254534d;
            });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
            {
                decimal result = 324.243342235m * 234.353254534m;
            });
        }

        private static void DivideTest()
        {
            ResultsLogger.Log("Divide test");

            StopwatchMeasures.MeasureTime(
                "Int",
                () =>
            {
                int result = 442 / 142;
            });

            StopwatchMeasures.MeasureTime(
                "Long",
                () =>
            {
                long result = 68548 / 6442;
            });

            StopwatchMeasures.MeasureTime(
                "Float",
                () =>
            {
                float result = 311.1253f / 14242.6456f;
            });

            StopwatchMeasures.MeasureTime(
                "Double",
                () =>
            {
                double result = 324.23235d / 234.3254534d;
            });

            StopwatchMeasures.MeasureTime(
                "Decimal",
                () =>
            {
                decimal result = 324.243342235m / 234.353254534m;
            });
        }
    }
}
