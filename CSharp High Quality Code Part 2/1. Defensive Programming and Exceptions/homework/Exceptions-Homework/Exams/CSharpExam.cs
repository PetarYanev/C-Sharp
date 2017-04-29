using System;
using Exceptions_Homework.Utils;

namespace Exceptions_Homework.Exams
{
    public class CSharpExam : Exam
    {
        private const int MinScore = 0;
        private const int MaxScore = 100;

        private int score;

        public CSharpExam(int score)
        {
            this.Score = score;
        }

        public int Score
        {
            get
            {
                return this.score;
            }

            private set
            {
                if (!Validator.ValidateIntRange(value, MinScore, MaxScore))
                {
                    throw new ArgumentOutOfRangeException($"The score must be between {MinScore} - {MaxScore}");
                }
                else
                {
                    this.score = value;
                }
            }
        }

        public override ExamResult Check()
        {
            var examResult = new ExamResult(this.Score, MinScore, MaxScore, "Exam results calculated by score.");

            return examResult;
        }
    }
}
