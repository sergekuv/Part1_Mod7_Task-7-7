using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    class Address
    {
        string appartment;
        string building;
        string street;
        string city;
        string postalCode;
        string PostalCode
        {
            get
            {
                return postalCode;
            }
            set
            {
                if(value.Length == 6 && Int32.TryParse(value, out int result))      // индекс должен быть 6-значным числом
                {
                    postalCode = value;
                }
                else
                {
                    Console.WriteLine("Индекс не выглядит корректным");
                }
            }
        }

        internal string Show() => $"Адрес: {postalCode}, {city}, {street}, дом {building},  кв. {(String.IsNullOrWhiteSpace(appartment) ? "нет" : appartment)}"; 
        internal Address (string apt = "11", string bld = "1", string st = "Street Name", string ct = "City", string postCode = "123456")
        {
            appartment = apt;
            building = bld;
            street = st;
            city = ct;
            postalCode = postCode;
        }

    }
}
