using System;
using System.Collections.Generic;
using System.Text;

namespace encapsulation_using_constructor
{
    internal class employee
    {
        private int employ_id;
        private string employ_name;
        private string employ_email;
        private string employ_department;
        private int age;

        //constructor->

        //public employee(int id,string name,string email,string department,int age_)
        //{
        //    employ_id = id;
        //    employ_name = name;
        //    employ_email = email;
        //    employ_department = department;
        //    age=age_;
        //}



        //gettersetter->

        public int id
        {
            get { return employ_id; }
            set { employ_id = value; }
        }

        public string name
        {
            get { return employ_name; }
            set { employ_name= value; }
        }


        public string email
        {
            get { return employ_email; }
            set { employ_email = value; }
        }
        public string dep
        {
            get { return employ_department; }
            set { employ_department = value; }
        }

        public int age_
        {
            get { return age; }
            set
            {
                if(value>18)
                {
                    age = value;
                }
            }
        }
        public void emp_details()
        {
            Console.WriteLine(employ_id);
            Console.WriteLine(employ_name);
            Console.WriteLine(employ_email);
            Console.WriteLine(employ_department);
            Console.WriteLine(age);


         }
        }
}
