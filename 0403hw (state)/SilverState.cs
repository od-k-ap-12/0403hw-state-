using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _0403hw__state_
{
    class SilverState : State
    {

        private void Initialize()
        {
            interest = 0.01;
            lowerLimit = 0.0;
            upperLimit = 1000.0;
        }

        private void StateChangeCheck()
        {
            if (balance < lowerLimit)
            {
                account.SetState(new RedState(this));
            }
            else if (balance > upperLimit)
            {
                account.SetState(new GoldState(this));
            }
        }

        public SilverState(double balance, Account account)
        {

            this.balance = balance;
            this.account = account;
            Initialize();
        }

        public SilverState(State state)
        {
            this.balance = state.GetBalance();
            this.account = state.GetAccount();
            Initialize();
        }

        public override void Deposit(double amount)
        {
            balance += amount;
            StateChangeCheck();
        }

        public override bool Withdraw(double amount)
        {
            balance -= amount;
            StateChangeCheck();
            return true;
        }

        public override bool PayInterest()
        {
            balance += interest * balance;
            StateChangeCheck();
            return true;
        }
    };
}
