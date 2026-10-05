using System;


    internal class Shop
    {
        //parent class
      
        public int shop_no;
        public int shop_pin;
        public virtual void shopdetails(int shop_no)
        {
            if (shop_no == 0)
            {
                Console.WriteLine("Shop is selling");
            }
        }
    }
