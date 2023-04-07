using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProblems
{
    public class Exercise
    {
        public string Description { get; set; }
        public int Points { get; set; }

        public Exercise(string Description, int Points)
        {
            this.Description = Description;
            this.Points = Points;   
        }

        public override string ToString()
        {
            return $"{Description}";
        }
    }
}
