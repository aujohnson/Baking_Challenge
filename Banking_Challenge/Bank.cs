using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Challenge
{
    public class Bank
    {
        private List<Account> _accounts = new List<Account>();

        public List<Account> GetList() => _accounts;

        public void AddAccount(Account a) => _accounts.Add(a);
    }



    public abstract class Account
    {
        public string Owner { get; set; }

        public decimal Balance { get; set; }

        public virtual void Withdraw(decimal amt)
        {
            Balance -= amt;
        }

        public void Deposit(decimal amt)
        {
            Balance += amt;
        }

        public void Transfer(Individual from, Individual to, decimal amt)
        {
            Bank money = new Bank();
            to.Balance += amt;
            from.Balance -= amt;
        }
    }

    public class CD : Account
    {

    }

    public abstract class MoneyMarket : Account
    {

    }

    public class Individual : MoneyMarket
    {
        public override void Withdraw(decimal amt)
        {
            if (amt < 1000)
            {
                base.Withdraw(amt);
            }
        }
    }

    public class Corporate : MoneyMarket
    {

    }
}
