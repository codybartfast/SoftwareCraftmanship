using Microsoft.VisualStudio.TestTools.UnitTesting;
using ObjectCalisthenics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectCalisthenics
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositAccceptanceTest()
        {
            var depositAmount = new Amount(10.11m);
            var account = new Account();
            var balanceBeforeDeposit = account.GetBalance();
            var expectedBalance = balanceBeforeDeposit + depositAmount;

            account.AcceptDeposit(depositAmount);

            var balanceAfterDeposit = account.GetBalance();
            Assert.AreEqual(expectedBalance, balanceAfterDeposit);
        }

        [TestMethod()]
        public void WithdrawAcceptanceTest()
        {
            var withdrawalAmount = new Amount(10.11m);
            var account = new Account();
            var balanceBeforeWithdrawal = account.GetBalance();
            var expectedBalance = balanceBeforeWithdrawal - withdrawalAmount;

            account.AcceptWithdrawal(withdrawalAmount);

            var balanceAfterWithdrawal = account.GetBalance();
            Assert.AreEqual(expectedBalance, balanceAfterWithdrawal);
        }
    }
}