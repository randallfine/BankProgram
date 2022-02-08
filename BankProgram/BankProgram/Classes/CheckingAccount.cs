using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram.Classes
{
    public class CheckingAccount : Account
    {
        public CheckingAccount(int id):base(id)
        {
            OwnerId = id;
        }

        public CheckingAccount(int id, decimal startingBalance):base(id, startingBalance)
        {
            Balance = startingBalance;
            OwnerId = id;
        }
    }
}
