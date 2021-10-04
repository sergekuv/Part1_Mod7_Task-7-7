using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    class HomeDelivery : Delivery           // см. комментарий к базовому классу
    {
        internal override void Deliver()
        {
            Console.WriteLine($"Delivered at {factDateTime} to {address.Show()} ");
        }
    }
}
