using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace opps
{
    internal class student
    {
        public int student_id;
        public string student_name;
        public string department;

        public void student_details()
        {
            Console.WriteLine(student_id);
            Console.WriteLine(student_name);
            Console.WriteLine(department);
        }

    }
}
