using System;

internal class GroceryShop : Shop
{
    //child class 2
    public int shop2_no=2;
    public override void shopdetails(int shop_no)
    {
        if (shop_no == shop2_no)
        {
            Console.WriteLine("this is grocery shop");
        }
        else
        {
            Console.WriteLine("this is not a grocery shop");
        }

    }
}
