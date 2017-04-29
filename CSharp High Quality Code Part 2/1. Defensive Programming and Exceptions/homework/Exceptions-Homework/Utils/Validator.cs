namespace Exceptions_Homework.Utils
{
    internal class Validator
    {
        public static bool ValidateIntRange(int value, int minValue = int.MinValue, int maxValue = int.MaxValue)
        {
            var isInRange = minValue <= value && value <= maxValue;

            return isInRange;
        }

        public static bool ValidateString(string inputString)
        {
            var isValid = !string.IsNullOrEmpty(inputString);

            return isValid;
        }
    }
}
