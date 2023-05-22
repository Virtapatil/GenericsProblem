using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericProblem
{
    internal class GenericMaxMethod
    {
        public static string MaxString(params string[] strings)
        {
            if (strings == null || strings.Length == 0)
            {
                throw new ArgumentException("The input array must not be empty.");
            }

            return strings.OrderByDescending(s => s).FirstOrDefault();
        }
    }
}
