using System;
using System.Collections.Generic;
using System.Text;

namespace encapsulation_using_constructor
{
    internal class student
    {
        private string student_name;
        private int student_marks;


        public string name
        {
            get { return student_name; }
            set { student_name = value; }
        }
        public int marks
        {
            get { return student_marks; }
            set
            {
                if(value > 40)
                {
                    student_marks = value;
                }
            }
        }
        public void student_details()
        {
            Console.WriteLine(student_name);
            Console.WriteLine(student_marks);
        }
    }
}
