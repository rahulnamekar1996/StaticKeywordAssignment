using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
   public class AmbuiguityOverloadingDemo
    {
       
        public void OverloadedMethod(int x, int y)
        {
            Console.WriteLine("Method with two int parameters called.");
        }

       
        public void OverloadedMethod(int x, double y)
        {
            Console.WriteLine("Method with int and double parameters called.");
        }


    }
}
