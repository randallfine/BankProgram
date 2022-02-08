using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProgram.Classes
{
    public class Bank
    {
        public string Name { get; set; }
        public List<Account> accounts = new List<Account>();

        public Bank(string name)
        {
            Name = name;
        }

        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

    }
}
