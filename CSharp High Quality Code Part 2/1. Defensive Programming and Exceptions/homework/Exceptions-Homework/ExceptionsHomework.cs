using System;
using System.Collections.Generic;
using Exceptions_Homework.Exams;
using Exceptions_Homework.Students;

public class ExceptionsHomework
{
    public static void Main()
    {
        var substr = HelperMethods.GetSubsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = HelperMethods.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = HelperMethods.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = HelperMethods.GetSubsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        var extractEndingStrings = new Dictionary<string, int>()
            {
                { "I love C#", 2 },
                { "Nakov", 4 },
                { "beer", 4 },
                { "Hi", 100 }
            };

        foreach (var str in extractEndingStrings)
        {
            try
            {
                Console.WriteLine(HelperMethods.ExtractEnding(str.Key, str.Value));
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        try
        {
            HelperMethods.CheckPrime(23);
            Console.WriteLine("23 is prime.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        try
        {
            HelperMethods.CheckPrime(33);
            Console.WriteLine("33 is prime.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };

        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
