using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Subjects
    {
        private string Name { get; set; }
        private string Description { get; set; }

    }

    class Assesment
    {
        private string Name { get; set; }
        private int OutOof { get; set; }
        private string Topic { get; set; }
        private string Type { get; set; } //homework , classwork
        
        private Teacher TeacherName;

        private DateTime GivenDate { get; set; }

        private DateTime SubmittedDate { get; set; }

    }
}
