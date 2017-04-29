using System;
using System.Collections.Generic;
using System.Text;
using Exceptions_Homework.Utils;

namespace Exceptions_Homework.Students
{
    public class HelperMethods
    {
        public static T[] GetSubsequence<T>(T[] arr, int startIndex, int count)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new ArgumentNullException("The array cannot be null or empty!");
            }

            if (!Validator.ValidateIntRange(startIndex, 0, arr.Length - 1))
            {
                throw new ArgumentOutOfRangeException("The start index must be between 0 and the array length!");
            }

            var maxCountValue = arr.Length - startIndex;
            if (!Validator.ValidateIntRange(count, 0, maxCountValue))
            {
                throw new ArgumentOutOfRangeException("The count must be between 0 and array length minus start index!");
            }

            List<T> result = new List<T>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(arr[i]);
            }

            return result.ToArray();
        }

        public static string ExtractEnding(string str, int count)
        {
            if (!Validator.ValidateString(str))
            {
                throw new ArgumentNullException($"The input string: '{str}', cannot be null or empty!");
            }

            if (!Validator.ValidateIntRange(count, 0, str.Length))
            {
                throw new ArgumentOutOfRangeException($"The count: '{count}', must be between zero and input string length!");
            }

            StringBuilder result = new StringBuilder();
            for (int i = str.Length - count; i < str.Length; i++)
            {
                result.Append(str[i]);
            }

            return result.ToString();
        }

        public static void CheckPrime(int number)
        {
            var minPrimeNumber = 2;

            if (!Validator.ValidateIntRange(number, minPrimeNumber))
            {
                throw new ArgumentOutOfRangeException($"{number} must be between 2 and max int value!");
            }

            var mathSqrtOfNumber = Math.Sqrt(number);
            for (int divisor = 2; divisor <= mathSqrtOfNumber; divisor++)
            {
                if (number % divisor == 0)
                {
                    throw new ArgumentException($"{number} is not prime!");
                }
            }
        }
    }
}
