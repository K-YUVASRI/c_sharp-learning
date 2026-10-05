//encapusulation->combine both data(instance variavle) & methon into a single class
//2 types 1)constructor 2) get setter


using encapsulation_using_constructor;
using System;
class Program
{
public static void Main()
    {

        //constructor
        //employee e1 = new employee(1, "bhavani", "bhavani@123gmail.com", "MECH",25);
        //e1.emp_details();


       //GETTERSETTER
       //employee obj1= new employee();
       // obj1.id = 1;
       // obj1.name = "likitha";
       // obj1.email = "likitha@123gmail.com";
       // obj1.dep = "ece";
       // obj1.age_ = 35;
       // obj1.emp_details();


        student std1=new student();
        std1.name = "pavi";
        std1.marks = 43;
        std1.student_details();
       
    }
}