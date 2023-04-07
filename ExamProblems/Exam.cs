using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblems
{
    public class Exam
    {
        public string Month { get; set; }
        public int Year { get; set; }
        public Exercise exercise1 { get; set; }
        public Exercise exercise2 { get; set; }

        public Exam(string Month, int Year, Exercise exercise1, Exercise exercise2)
        {
            this.Month = Month;
            this.Year = Year;
            this.exercise1 = exercise1;
            this.exercise2 = exercise2;
        }

        public override string ToString()
        {
            return $"{Month} - {Year}";
        }

    }
}
