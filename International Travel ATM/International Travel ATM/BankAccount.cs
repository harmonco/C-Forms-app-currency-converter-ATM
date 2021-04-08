using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace International_Travel_ATM
{
    class BankAccount
    {
        //create balance
        private decimal _balance;

        //constructor for bank account
        public BankAccount(decimal startingBalance)
        {
            _balance = startingBalance;
        }

        //balance as a read-only
        public decimal Balance
        {
            get { return _balance; }
        }

        //Deposit method
        public void Deposit(decimal amount)
        {
            _balance += amount;
        }

        //Withdraw method
        public void Withdraw(decimal amount)
        {
            _balance -= amount;
        }
    }
}
