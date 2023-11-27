using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_based_system
{
    internal class Subject
    {
        public string Name;
        public int SubjectCode;
        public string Teacher;

        public Subject()
        {
        }

        public Subject(string name, int subjectCode, string teacher)
        {
            Name = name;
            SubjectCode = subjectCode;
            Teacher = teacher;
        }

    }
}
