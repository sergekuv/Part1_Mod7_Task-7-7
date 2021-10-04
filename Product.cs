using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    class Product
    {
        string partNumber;
        string name;
        decimal basePrice;
        public string PartNumber
        {
            get
            {
                return partNumber;
            }
        }
        internal Product(string pn, string name = "auto generated", decimal price = 0)
        {
            partNumber = pn;
            this.name = name;
            this.basePrice = price;
        }
        internal string Show() => partNumber + " " + name;
    }
}
