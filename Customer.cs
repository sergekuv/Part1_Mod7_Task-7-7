using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    internal enum Level
    {
        Basic,
        Silver,
        Gold
    }
    class Customer<TAge> : Person<TAge>
    {
        Level status;
        Address address;    // пример композиции
        Contact contact;

        internal override string Show()
        {
            return base.Show() + $" status: {status}; phone: {contact.Phone}; email: {contact.Email} \naddress: {address.Show()}";
        }
        internal Customer(TAge age, string name, string surname) : base(age, name, surname)
        {
            address = new Address(apt : "22");
            contact = new Contact();
        }
    }


}
