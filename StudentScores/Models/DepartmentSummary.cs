using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentScores.Models
{
    public class DepartmentSummary
    {
        public string Department { get; set; }
        public int NumberOfStudents { get; set; }
        public int MaxPerDepartment { get; set; }

        public override string ToString()
        {
            return $"{Department}: {NumberOfStudents} students (Max: {MaxPerDepartment})";
        }
    }
}
