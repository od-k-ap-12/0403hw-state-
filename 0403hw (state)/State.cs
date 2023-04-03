using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _0403hw__state_
{
    abstract class State
    {
        protected Account account;
        protected double balance;
        protected double interest;
        protected double lowerLimit;
        protected double upperLimit;
        public Account GetAccount()
        {
            return account;
        }
        public void SetAccount(Account account)
        {
            this.account = account;
        }
        public double GetBalance()
        {
            return balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
        abstract public void Deposit(double amount);
        abstract public bool Withdraw(double amount);
        abstract public bool PayInterest();
    };
}