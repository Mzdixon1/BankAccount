using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project_3
{
    class Checking_Account : Bank_Account
    {
        public Checking_Account(string UserFirstName, string UserLastName, double UserAccountNumber, decimal UserCurrentBalance) :
            base(UserFirstName, UserLastName, UserAccountNumber, UserCurrentBalance)
        {
            UserFirstName = "Mary";
            UserLastName = "Jane";

        }
        public override void Deposit(decimal checkingDeposit)
        {
            UserCurrentBalance += checkingDeposit;
            
        }
        public override void Withdrawl(decimal checkingWithdrawl)
        {
            UserCurrentBalance -= checkingWithdrawl;
        }
    }
}
