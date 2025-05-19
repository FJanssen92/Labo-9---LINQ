using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores.Models
{
    public class Summary
    {
        public int NumberOfStudents { get; set; }
        public int MinimumGrade { get; set; }
        public int MaximumGrade { get; set; }
        public double AverageGrade { get; set; }

        public override string ToString()
        {
            return $"Aantal studenten: {NumberOfStudents} - Minimum: {MinimumGrade} - Maximum: {MaximumGrade} - Average: {AverageGrade}";
        }
    }
}
