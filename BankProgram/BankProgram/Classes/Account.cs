using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram.Classes
{
   public abstract class Account
    {
        public Decimal Balance { get; set; }
        public int OwnerId { get; set; }

        public Account(int id)
        {
            OwnerId = id;
        }

        public Account(int id, decimal startingBalance)
        {
            Balance = startingBalance;
            OwnerId = id;
        }
        public virtual bool Withdraw(decimal amount)
        {
            if(Balance < amount && amount > 0)
            {
                return false;
            }

            Balance -= amount;

            return true;
        }

        public virtual bool Deposit(decimal amount)
        {
           if(amount > 0)
            {
                Balance += amount;
                return true;
            }

           return false;
           
        }

        public virtual void Transfer(decimal amount, Account toAccount)
        {
            try
            {
                if (Withdraw(amount))
                {
                    toAccount.Deposit(amount);
                } 
                else
                {
                    Console.WriteLine("Unable to Transfer");
                }

            } 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public virtual decimal GetBalance()
        {
            return Balance;
        }
    }
}
