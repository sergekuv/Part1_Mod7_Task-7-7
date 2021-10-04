using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    abstract class Delivery                     // вроде бы, и без этого класса весь нужный синтаксис присутствует. И раз так, давайте пока забудлем про этот класс
                                                // ( не очень хорошо представляю, как он должен выглядеть) 
    {
        string number;
        protected DateTime planDateTime;
        protected DateTime factDateTime;
        protected Address address;
        internal abstract void Deliver();
    }
}
