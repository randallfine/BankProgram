using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram.Classes
{
    public class CorperateInvestmentAccount: InvestmentAccount
    {
        public CorperateInvestmentAccount(int id):base(id)
        {
            OwnerId = id;
        }
        public CorperateInvestmentAccount(int id, decimal startingBalance):base(id)
        {
            Balance = startingBalance;
            OwnerId = id;
        }

    }
}
