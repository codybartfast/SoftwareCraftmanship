using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    public class Amount
    {
        readonly decimal amount;
        public Amount(decimal amount)
        {
            this.amount = amount;
        }

        public static Amount operator +(Amount firstAmount, Amount secondAmount)
        {
            var firstRaw = firstAmount.amount;
            var secondRaw = secondAmount.amount;
            return new Amount(firstRaw + secondRaw);
        }

        public static Amount operator -(Amount firstAmount, Amount secondAmount)
        {
            var firstRaw = firstAmount.amount;
            var secondRaw = secondAmount.amount;
            return new Amount(firstRaw - secondRaw);
        }

        public override bool Equals(object other)
        {
            var otherAmount = other as Amount;
            if(otherAmount == null)
                return false;
            return amount == otherAmount.amount;
        }
    }
}
