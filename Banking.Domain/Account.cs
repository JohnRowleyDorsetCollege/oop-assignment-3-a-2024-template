using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking.Domain
{
    public abstract class Account
    {
        public string AccountName { get; set; }

        public Account(string firstName, string lastName)
        {
            AccountName = GenerateAccountName(firstName, lastName);
        }

        public string GenerateAccountName(string firstName, string lastName)
        {
            // Introduce the rules for creating account names here
            throw new NotImplementedException();
        }
    }
}
