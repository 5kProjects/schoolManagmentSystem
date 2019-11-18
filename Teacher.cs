using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Teacher
    {
        private string FName { get; set; }
        private string LName { get; set; }

        public string FullName => $"{FName} {LName}";
        private string Id { get; set; }
        private string experiance { get; set; }

        public List<Subjects> TeachingSubjects { get; set; } = new List<Subjects>();
        public List<Classes> TeachingClasses { get; set; } = new List<Classes>();


    }
    
}
