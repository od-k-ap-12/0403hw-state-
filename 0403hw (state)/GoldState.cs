using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _0403hw__state_
{
    class GoldState : State
    {

        private void Initialize()
        {
            interest = 0.07;
            lowerLimit = 1000.0;
            upperLimit = 10000000.0;
        }

        private void StateChangeCheck()
        {
            if (balance < 0.0)
            {
                account.SetState(new RedState(this));
            }
            else if (balance < lowerLimit)
            {
                account.SetState(new SilverState(this));
            }
        }

        GoldState(double balance, Account account)
        {

            this.balance = balance;
            this.account = account;
            Initialize();
        }

        public GoldState(State state)
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
