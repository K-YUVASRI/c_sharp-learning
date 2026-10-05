using System;
class program
{
    public static void Main()
    {
        //integer:whole nomber 0-9
        int a = 1;
        //long integer more than 9 digits
        long b = 456987125574;
        //float-> end f
        float c = 8.5f;
        //double int after point more then 6 digit
        double d = 1.12365478;
        //decimal-> end m
        decimal e = 2153.258741m;
        //char
        char f='A';
        //string
        string name = "yuvasri";
        //boolean
        bool g=true;
        //date time
        DateTime h=DateTime.Now;
        //dateonly
        DateOnly i=new DateOnly();
        DateOnly j = new DateOnly(2005,10,8);
        DateOnly k = DateOnly.FromDateTime(DateTime.Now);
        TimeOnly l = TimeOnly.FromDateTime(DateTime.Now);
        Console.WriteLine(a);
        Console.WriteLine(b); 
        Console.WriteLine(c);
        Console.WriteLine(d);
        Console.WriteLine(e);
        Console.WriteLine(f);
        Console.WriteLine(g);
        Console.WriteLine(h);
        Console.WriteLine(i);
        Console.WriteLine(j);
        Console.WriteLine(k);
        Console.WriteLine(l);
    }
}