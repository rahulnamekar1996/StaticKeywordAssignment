using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class StaticMethodOverloading
    {
        // Static method to add two integers
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Overloaded static method to add three integers
        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Overloaded static method to add two doubles
        public static double Add(double a, double b)
        {
            return a + b;
        }


    }
}
