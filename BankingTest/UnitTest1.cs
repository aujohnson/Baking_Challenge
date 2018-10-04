using System;
using Bank_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CreditUnionTests
    {
        [TestMethod]
        public void CreditUnion_GetList_ShouldReturnExpectedCountList()
        {
            //Arrange
            Bank union = new Bank();
            var expected = union.GetList().Count;
            var actual = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestClass]
        public class Account
        {
            [TestMethod]
            public void Account_Deposit_ShouldIncrease()
            {
                Individual consumer = new Individual();

                consumer.Deposit(10);

                var actual = consumer.Balance;
                var expected = 10;

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Account_Withdraw_BalanceShouldDecrease()
            {
                Individual consumer = new Individual();

                consumer.Deposit(20);
                consumer.Withdraw(10);

                var expected = 10;
                var actual = consumer.Balance;

                Assert.AreEqual(expected, actual);
            }
            [TestMethod]
            public void Account_Transfer_MoneyShouldBeTransferred()
            {
                Individual consumer1 = new Individual();
                Individual consumer2 = new Individual()
                {
                    Owner = "Joe",
                    Balance = 1.5m,
                };

                Bank money = new Bank();

                money.AddAccount(consumer2);

                consumer1.Transfer(consumer1, consumer2, 2m);

                var expected = 3.5m;
                var actual = consumer2.Balance;

                Assert.AreEqual(expected, actual);
            }
        }
    }
}
