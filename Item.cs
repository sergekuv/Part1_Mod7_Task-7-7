using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    class Item 
    {
        internal Product product;
        int quantity;
        decimal price;

        internal Item(int pos, Product prod, int qnt = 1, decimal price = 0)
        {
            product = prod;
            quantity = qnt;
            this.price = price;
        }
        internal string Show() => product.Show() + "\tqty: " + quantity.ToString() + "\tprice: " + price.ToString();
    }
}
