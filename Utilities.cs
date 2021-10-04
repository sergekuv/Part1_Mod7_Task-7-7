using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Part1_Mod7_Task_7_7
{
    internal static class Utilities        // Поскольку предложено использовать статические классы/методы, 
    {
        internal static bool IsValidEmail(this string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        internal static void Show<T>(T arg)
        {
            Console.WriteLine(arg.ToString());
        }

        public static string ShowAge<TAge>(TAge age)
        {
            return age.ToString();      // тут могло бы быть что-то более полезное. Например, преобразование int или других нестроковых типов в возраст прописью
        }
    }

}

    //public interface IHasSHow
    //{
    //    internal string Show();
    //}

