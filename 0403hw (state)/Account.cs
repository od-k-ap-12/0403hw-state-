using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403hw__state_
{
    class Account
    {
        private State state;
        private string owner;
        public Account(string owner)
        {
            this.owner = owner;
        }
        public double GetBalance()
        {
            return state.GetBalance();
        }

        public State GetState()
        {
            return state;
        }

        public void SetState(State state)
        {
            this.state = state;
        }

        public void Deposit(double amount)
        {
            state.Deposit(amount);
            string buffer;
            buffer = "Deposited " + amount;
            Console.WriteLine(buffer);
            buffer = "Balance " + this.GetBalance();
            Console.WriteLine(buffer);
            buffer = "Status " + this.GetState();
            Console.WriteLine(buffer);
        }

        public void Withdraw(double amount)
        {
            if (state.Withdraw(amount))
            {
                string buffer;
                buffer = "Withdraw %f$ -----" + amount;
                Console.WriteLine(buffer);
                buffer = "Balance " + this.GetBalance();
                Console.WriteLine(buffer);
                buffer = "Status " + this.GetState();
                Console.WriteLine(buffer);
            }
        }

        public void PayInterest()
        {
            if (state.PayInterest())
            {
                string buffer;
                Console.WriteLine("Interest Paid -----\n");
                buffer = "Balance " + this.GetBalance();
                Console.WriteLine(buffer);
                buffer = "Status " + this.GetState();
                Console.WriteLine(buffer);
            }
        }
    };
}
