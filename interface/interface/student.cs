using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal class student
    {
        //composite method
        private readonly Istudent stu;

        //constructor creating
        public student(Istudent stud)
        {
            stu = stud;
        }



        public async void employeedetail()
        {
            await stu.employeedetail();
        }
    }
}
