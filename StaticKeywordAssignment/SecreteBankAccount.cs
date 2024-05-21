using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    internal class SecreteBankAccount
    {
        private double balance;
        private string presidentName;

        public SecreteBankAccount(string presidentName, double initialBalance)
        {
            this.presidentName = presidentName;
            balance = initialBalance;
        }

        
        private void AddMoney(double amount, string requester)
        {
            if (requester == presidentName)
            {
                balance += amount;
                Console.WriteLine($"{amount} added to the account. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("You do not have permission to add money to the account.");
            }
        }

       
        public void DisplayBalance()
        {
            Console.WriteLine($"Current balance: {balance}");
        }

       
        public void RequestAddMoney(double amount, string requester)
        {
            AddMoney(amount, requester);
        }

    }
}
