using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    abstract class Transaction
    {
        readonly protected Amount amount;

        public Transaction(Amount amount)
        {
            this.amount = amount;
        }

        public abstract Amount AddTo(Amount givenAmount);
    }
}
