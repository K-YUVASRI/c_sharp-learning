using System;
class Program
{
    public static void Main()
    {
        //typecasting
        //1.implicit convertion->automation conversion->it goes short to long
        //int->long->float->double->decimal
        //2.explict conversion->mannually conversion->large to small
        //decimal->double->float->long->int
        int z = 44;
        long x = z;
        Console.WriteLine(x);


        decimal a = 56.5488m;
        long b = Convert.ToInt64 (a);
        Console.WriteLine(b);

        decimal c = 58.5488m;
        double d = Convert.ToDouble(c);
        Console.WriteLine(d);

        decimal e = 58.5488m;
        float f = Convert.ToSingle(e);
        Console.WriteLine(f);

        decimal g = 58.5488m;
        int h = Convert.ToInt32(g);
        Console.WriteLine(h);


    }
}