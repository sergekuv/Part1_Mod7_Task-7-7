using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Mod7_Task_7_7
{
    abstract class Person<TAge>     // Извините - по-настоящему полезного применения обобщений не смог придумать((
    {
        string firstName;
        string lastName;
        TAge age;

        internal Person(TAge age, string fName, string lName)       
        {
            this.age = age;         
            firstName = fName;
            lastName = lName;
        }
        internal virtual string Show()
        {
            return firstName + " " + lastName + Utilities.ShowAge(age);
        }
    }
}
