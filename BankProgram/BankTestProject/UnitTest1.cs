using BankProgram.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankTestProject
{
    [TestClass]
    public class UnitTest1
    {
        CheckingAccount c = new(1);
        IndividualInvestmentAccount i = new(1);
        [TestMethod]
        public void TestDeposit()
        {
            c.Deposit(100m);
            i.Deposit(100m);
            Assert.AreEqual(c.GetBalance(), 100m);
            Assert.AreEqual(i.GetBalance(), 100m);
        }
        [TestMethod]
        public void TestWithdraw()
        {
            c.Withdraw(100m);
            i.Withdraw(100m);

            Assert.AreEqual(c.GetBalance(), 0);
            Assert.AreEqual(i.GetBalance(), 0);
        }

        [TestMethod]
        public void TestTransfer()
        {
            i.Deposit(1000m);
            i.Transfer(500m, c);
            Assert.AreEqual(c.GetBalance(), 500m);
            Assert.AreEqual(i.GetBalance(), 500m);
        }
    }
}