using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class ConvertCurrancy
    {
        public static double ConvertToDollars(double rupees)
        {
            double exchangeRate = 69.2;
            return rupees / exchangeRate;
        }

    }
}
