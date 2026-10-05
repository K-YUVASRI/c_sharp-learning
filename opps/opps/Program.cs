using opps;
using System;
class Program
{
    public static void Main()
    {
        student obj = new student();
        obj.student_id = 44;
        obj.student_name = "yuvasri";
        obj.department = "ai";
        obj.student_details();
        

        student obj1 = new student();
        obj1.student_id = 88;
        obj1.student_name = "vani";
        obj1.department = "cse";
        obj1.student_details();
    }
}