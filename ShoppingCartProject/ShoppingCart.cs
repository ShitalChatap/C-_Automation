using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class ShoppingCartRunner
    {
        static void Main(string[] args)
        {
            Item i1 = new Item();
            Item i2 = new Item();


            i1.id = 101;
            i1.description = "Laoptop";
            i1.Quantity = 8;
            i1.price = 1000;


            i2.id = 102;
            i2.description = "Watch";
            i2.Quantity = 2;
            i2.price = 55000;

            //Console.WriteLine(i1.GetHashCode());
            //Console.WriteLine(i2.GetHashCode());
            i1.DisplayItemDetail();
            i1.PrintDiscountPrice();



            i2.DisplayItemDetail();
            i2.PrintDiscountPrice();

        }
        internal class ShoppingCart
        {
            public int id;
            public String description;
            public int quantity;
            public double price;

            public void PrintItemDetails()
            {
                Console.WriteLine("id: " + id);
                Console.WriteLine("descr: " + descr);
                Console.WriteLine("quantity: " + quantity);
                Console.WriteLine("price: " + price);

                public void PrintItem()
                {
                    double final_price;
                    if (quantity == 2)
                    {
                        final_price = (price - (price * 10 / 100)) * quantity;
                        Console.WriteLine("Congrats you have get 10% discount :" + final_price);
                    }
                    else

                        if (quantity >= 3 && quantity < 5)
                    {
                        final_price = (price - (price * 15 / 100)) * quantity;
                        Console.WriteLine("Congrats you have get 15% discount :" + final_price);
                    }
                    else

                            if (quantity == 5)
                    {
                        final_price = (price - (price * 25 / 100)) * quantity;
                        Console.WriteLine("Congrats you have get 25% discount :" + final_price);
                    }



                }


            }
        }
    }
