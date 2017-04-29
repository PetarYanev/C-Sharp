using System;
using RotatingWalkInMatrix.Contracts;

namespace RotatingWalkInMatrix.Models
{
    public class Logger : ILogger
    {
        public void Write(string text)
        {
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(text);
        }
    }
}
