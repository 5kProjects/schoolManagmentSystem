using System;
using System.Collections.Generic;
using System.Text;

namespace project1
{
    class Student
    {

        public Student(string lName, string fName)
        {
            LName = lName;
            FName = fName;
        }

        private string FName { get; set; }        
        private string LName { get; set; }
          
        public string FullName => $"{FName} {LName}";
        private string Id { get; set; }
        private List<Teacher> persList = new List<Teacher>();

        private Parent Parent;



    }
}

