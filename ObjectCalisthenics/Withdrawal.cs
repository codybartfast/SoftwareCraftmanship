using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    class Withdrawal : Transaction
    {
        public Withdrawal(Amount amount) : base(amount)
        {
        }

        public override Amount AddTo(Amount givenAmount)
        {
            return givenAmount - amount;
        }
    }
}
