using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    internal enum Transtport
    {
        onFoot,
        onBike,
        onCar,
        onTruck
    }
    class Couruer : Person<int>
    {
        Transtport transtport;      
        bool available;
        Contact contact;
        internal Couruer(int age, string fname, string lname, Transtport transp, Contact cntct, bool avlb = true) : base(age, fname, lname)
        {
            transtport = transp;
            contact = cntct;
            available = avlb;
        }
    }
}
