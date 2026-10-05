using polymorphism_ex1;
using System;
class Program
{
    public static void Main()
    {
        shop s1 = new shop(500, "fruit", "yuva" );
        shop s2 = new shop(569, "flowers", "sri");

        s1.details();

    }
}