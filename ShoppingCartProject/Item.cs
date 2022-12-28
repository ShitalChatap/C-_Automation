using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartProject
{
    public class Item
    {
        public int id;
        public String description;
        public int _quantity;
        public double price;

        public Item()
        {
            _quantity = 1;
            Console.WriteLine("object created");
        }
        public int Quantity
        {
            set
            {
                if(value > 0)
                {
                    _quantity= value;
                }
                else
                {
                    Console.WriteLine("Qty cannot be negative!!");
                }
            }

        }


        public void DisplayItemDetail()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("descr: " + description);
            Console.WriteLine("quantity: " + _quantity);
            Console.WriteLine("price: " + price);
            Console.WriteLine("-----------------------------------------------");
        }

        public void PrintDiscountPrice()
        {
            if (_quantity == 2)
            {
                Console.WriteLine((price - (price * 10 / 100.0)) * _quantity);
            }
            else if (_quantity >= 3 && _quantity<=5)
            {
                Console.WriteLine((price - (price * 15 / 100.0)) * _quantity);
            }
            else if (_quantity > 5)
            {
                Console.WriteLine((price - (price * 25 / 100.0)) * _quantity);
            }
            else
            {
                Console.WriteLine("No discount");
            }
            Console.WriteLine("-----------------------------");
        }
    
      

    }

}
