using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram.Classes
{
    public class IndividualInvestmentAccount:InvestmentAccount
    {
        public IndividualInvestmentAccount(int id) : base(id)
        {
            OwnerId = id;
        }
        public IndividualInvestmentAccount(int id, decimal startingBalance) : base(id)
        {
            Balance = startingBalance;
            OwnerId = id;
        }

        public override bool Withdraw(decimal amount)
        {
            base.Withdraw(amount);

            if(amount > 500.00M)
            {
                Console.WriteLine($"{amount} is over the withdraw limit of this account");
                return false;
            }
            return true;
        }
    }
}
