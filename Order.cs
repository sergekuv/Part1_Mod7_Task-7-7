using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    class Order
    {
        string number;
        DateTime orderDate;
        DateTime deliveryDate;
        bool delivered;
        Customer<int> customer;
        //Delivery delivery;
        List<Item> items;

        internal Order(Customer<int> cust, string num)
        {
            orderDate = DateTime.Now;
            customer = cust;
            number = num;
            //delivery = new HomeDelivery();
            items = new List<Item>();
        }
        internal void AddItem(Item it)
        {
            this.items.Add(it);
        }

        internal Item this[string s]
        {
            get
            {
                foreach (Item it in this.items)
                {
                    if (s == it.product.PartNumber)
                    {
                        return it;
                    }
                }
                Console.WriteLine("index of product ot found in the order");
                return null;
            }
        }

        public static Order operator + (Order o, Item it)
        {
            o.items.Add(it);
            return o;           // наверное, нехорошо, что меняется один из агрументов, но я не смог, к сожалению, придумать лучшего применения перегрузки для данного кейса
        }
        internal void Show()
        {
            Console.WriteLine($"Order {number}:");
            Console.WriteLine(customer.Show());
            Console.WriteLine("Ordered items:");
            foreach (Item it in items)
            {
                Console.WriteLine(it.Show());
            }
        }

    }
}
