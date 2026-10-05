using System;
class Program
{
    public static void Main(string[] args)
    {


        //example-1

        //int a = Convert.ToInt32(Console.ReadLine());
        //int b = Convert.ToInt32(Console.ReadLine());
        //int c = Convert.ToInt32(Console.ReadLine());

        //if (a >= b && a >= c)
        //{
        //    Console.WriteLine(a);
        //}
        //else if (b >= a && b >= c)
        //{
        //    Console.WriteLine(b);
        //}
        //else
        //{
        //    Console.WriteLine(c);
        //}


        //example2
        
        
        int mark = Convert.ToInt32(Console.ReadLine());

        //if (mark >= 90 && mark <= 100)
        //{
        //    Console.WriteLine("A");
        //}
        //else if (mark >= 80)
        //{
        //    Console.WriteLine("B");
        //}
        //else if (mark >= 70)
        //{
        //    Console.WriteLine("C");
        //}
        //else if (mark >= 50)
        //{
        //    Console.WriteLine("D");
        //}
        //else
        //{
        //    Console.WriteLine("Fail");
        //}




        ////exampl-3
        //int year = Convert.ToInt32(Console.ReadLine());

        //if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        //{
        //    Console.WriteLine("Leap Year");
        //}
        //else
        //{
        //    Console.WriteLine("Not Leap Year");
        //}


//        ex - 4





//char ch = Convert.ToChar(Console.ReadLine());

//        if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
//        {
//            Console.WriteLine("Vowel");
//        }
//        else
//        {
//            Console.WriteLine("Consonant");
//        }


//        ex - 5


//string username = Console.ReadLine();
//        string password = Console.ReadLine();

//        if (username == "admin" && password == "1234")
//        {
//            Console.WriteLine("Login Success");
//        }
//        else
//        {
//            Console.WriteLine("Invalid Login");
//        }




//        ex - 6



//int units = Convert.ToInt32(Console.ReadLine());
//        int bill;

//        if (units <= 100)
//        {
//            bill = units * 5;
//        }
//        else if (units <= 200)
//        {
//            bill = (100 * 5) + ((units - 100) * 7);
//        }
//        else
//        {
//            bill = (100 * 5) + (100 * 7) + ((units - 200) * 10);
//        }

//        Console.WriteLine(bill);





//        ex - 7


//int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        int c = Convert.ToInt32(Console.ReadLine());

//        if (a + b > c && b + c > a && a + c > b)
//        {
//            Console.WriteLine("Valid Triangle");
//        }
//        else
//        {
//            Console.WriteLine("Invalid Triangle");
//        }






//        ex - 8



//int balance = Convert.ToInt32(Console.ReadLine());
//        int amount = Convert.ToInt32(Console.ReadLine());

//        if (amount > 0 && amount <= balance && amount % 100 == 0)
//        {
//            balance = balance - amount;
//            Console.WriteLine("Withdrawal Successful");
//            Console.WriteLine(balance);
//        }
//        else
//        {
//            Console.WriteLine("Invalid Transaction");
//        }




//        ex - 9


//int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        int c = Convert.ToInt32(Console.ReadLine());

//        if (a > b && a > c)
//        {
//            Console.WriteLine("A is Largest");
//        }
//        else if (b > a && b > c)
//        {
//            Console.WriteLine("B is Largest");
//        }
//        else if (c > a && c > b)
//        {
//            Console.WriteLine("C is Largest");
//        }
//        else
//        {
//            Console.WriteLine("Some Values are Equal");
//        }





//        ex - 10


//int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        int c = Convert.ToInt32(Console.ReadLine());

//        if (a <= b && a <= c)
//        {
//            Console.WriteLine(a);
//        }
//        else if (b <= a && b <= c)
//        {
//            Console.WriteLine(b);
//        }
//        else
//        {
//            Console.WriteLine(c);
//        }




//        ex - 11



//char ch = Convert.ToChar(Console.ReadLine());

//        if (ch >= 'A' && ch <= 'Z')
//        {
//            Console.WriteLine("Uppercase");
//        }
//        else if (ch >= 'a' && ch <= 'z')
//        {
//            Console.WriteLine("Lowercase");
//        }
//        else if (ch >= '0' && ch <= '9')
//        {
//            Console.WriteLine("Digit");
//        }
//        else
//        {
//            Console.WriteLine("Special Character");
//        }

//        ex - 12



//int age = Convert.ToInt32(Console.ReadLine());

//        if (age < 0)
//        {
//            Console.WriteLine("Invalid Age");
//        }
//        else if (age <= 12)
//        {
//            Console.WriteLine("Child");
//        }
//        else if (age <= 19)
//        {
//            Console.WriteLine("Teenager");
//        }
//        else if (age <= 59)
//        {
//            Console.WriteLine("Adult");
//        }
//        else
//        {
//            Console.WriteLine("Senior Citizen");
//        }




//        ex - 13


//int cp = Convert.ToInt32(Console.ReadLine());
//        int sp = Convert.ToInt32(Console.ReadLine());

//        if (sp > cp)
//        {
//            Console.WriteLine("Profit");
//            Console.WriteLine(sp - cp);
//        }
//        else if (cp > sp)
//        {
//            Console.WriteLine("Loss");
//            Console.WriteLine(cp - sp);
//        }
//        else
//        {
//            Console.WriteLine("No Profit No Loss");
//        }




//        ex - 14


//double weight = Convert.ToDouble(Console.ReadLine());
//        double height = Convert.ToDouble(Console.ReadLine());

//        double bmi = weight / (height * height);

//        if (bmi < 18.5)
//        {
//            Console.WriteLine("Underweight");
//        }
//        else if (bmi < 25)
//        {
//            Console.WriteLine("Normal");
//        }
//        else if (bmi < 30)
//        {
//            Console.WriteLine("Overweight");
//        }
//        else
//        {
//            Console.WriteLine("Obese");
//        }


//        ex - 15


//int attendance = Convert.ToInt32(Console.ReadLine());
//        int internalMark = Convert.ToInt32(Console.ReadLine());
//        bool assignment = Convert.ToBoolean(Console.ReadLine());

//        if (attendance >= 75 && internalMark >= 40 && assignment)
//        {
//            Console.WriteLine("Eligible for Exam");
//        }
//        else if (attendance < 75)
//        {
//            Console.WriteLine("Attendance Shortage");
//        }
//        else if (internalMark < 40)
//        {
//            Console.WriteLine("Internal Mark Shortage");
//        }
//        else
//        {
//            Console.WriteLine("Assignment Not Submitted");
//        }



    }
}


