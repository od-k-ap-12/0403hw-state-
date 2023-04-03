using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0403hw__state_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Bank depositor");
            account.SetState(new SilverState(0.0, account));
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.PayInterest();
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);
            account.PayInterest();
        }
    }
}
