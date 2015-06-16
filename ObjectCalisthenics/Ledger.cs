using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    class Ledger
    {
        List<Transaction> transactions = new List<Transaction>();

        public void RecordTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
        }

        public Amount GetCurrentBalance()
        {
            var total = new Amount(0);
            foreach(var transaction in transactions)
            {
                total = transaction.AddTo(total);
            }
            return total;
        }
    }
}
