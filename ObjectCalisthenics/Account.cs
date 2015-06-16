using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    public class Account
    {
        Ledger ledger = new Ledger();

        public void AcceptDeposit(Amount amount)
        {
            var deposit = new Deposit(amount);
            ledger.RecordTransaction(deposit);
        }

        public void AcceptWithdrawal(Amount amount)
        {
            var withdrawal = new Withdrawal(amount);
            ledger.RecordTransaction(withdrawal);
        }

        public Amount GetBalance()
        {
            return ledger.GetCurrentBalance();
        }
    }
}
