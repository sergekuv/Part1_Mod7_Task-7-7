using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    class Contact 
    {
        string email;
        internal string Phone { get; set; }       // можно реализовать проверку логики в set
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.IsValidEmail())
                {
                    email = value;
                }
                else
                {
                    Console.WriteLine("Email не выглядит корректным");
                }

            }

        }
        internal Contact (string eml = "sample@mail.com", string ph = "1234567")
        {
            Email = eml;
            Phone = ph;
        }
    }
}
