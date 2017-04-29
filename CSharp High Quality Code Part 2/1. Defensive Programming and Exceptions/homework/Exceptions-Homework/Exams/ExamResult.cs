using System;
using Exceptions_Homework.Utils;

namespace Exceptions_Homework.Exams
{
    public class ExamResult
    {
        private const int MinGradeValue = 0;

        private int grade;
        private int minGrade;
        private int maxGrade;
        private string comments;

        public ExamResult(int grade, int minGrade, int maxGrade, string comments)
        {
            this.Grade = grade;
            this.MinGrade = minGrade;
            this.MaxGrade = maxGrade;
            this.Comments = comments;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                if (!Validator.ValidateIntRange(value, MinGradeValue))
                {
                    throw new ArgumentOutOfRangeException("Grade must be a positive number!");
                }
                else
                {
                    this.grade = value;
                }
            }
        }

        public int MinGrade
        {
            get
            {
                return this.minGrade;
            }

            private set
            {
                if (!Validator.ValidateIntRange(value, MinGradeValue))
                {
                    throw new ArgumentOutOfRangeException("Min grade must be a positive number!");
                }
                else
                {
                    this.minGrade = value;
                }
            }
        }

        public int MaxGrade
        {
            get
            {
                return this.maxGrade;
            }

            private set
            {
                if (!Validator.ValidateIntRange(value, this.MinGrade))
                {
                    throw new ArgumentOutOfRangeException($"Max grade must be a grater or equal to min grade = {this.MinGrade}");
                }
                else
                {
                    this.maxGrade = value;
                }
            }
        }

        public string Comments
        {
            get
            {
                return this.comments;
            }

            private set
            {
                if (!Validator.ValidateString(value))
                {
                    throw new ArgumentNullException("Commnets cannot be null or empty!");
                }
                else
                {
                    this.comments = value;
                }
            }
        }
    }
}
