using System;

internal class ClothingShop : Shop
{
    //child class 1
    public int shop1_no = 1;
    public override void shopdetails(int shop_no)
    {
        if (shop_no == shop1_no)
        {
            Console.WriteLine("this is clothing shop");
        }
        else
        {
            Console.WriteLine("this is not a clothing shop");
        }

    }
}
