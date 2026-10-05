
using System;

class Program
{
    public static void Main()
    {
        //special variable
        Shop sp=new Shop();
        
        sp.shopdetails(0);


        //obj of clothing shop
        sp = new ClothingShop();
        sp.shopdetails(2);

        ////obj for grocery shop
        sp = new GroceryShop();
        sp.shopdetails(2);
    }
}