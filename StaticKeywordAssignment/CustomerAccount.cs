using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class CustomerAccount
    {
        private double balance;

        public CustomerAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount} from account. Remaining balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void MakeDebitCardPayment(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Debit card payment of {amount} made. Remaining balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }

        }
        public void UseNetBanking(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Net banking transaction of {amount} made. Remaining balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }


    }
}