using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project_3
{
    class Reserve_Account : Bank_Account
    {
        public Reserve_Account(string UserFirstName, string UserLastName, double UserAccountNumber, decimal UserCurrentBalance) :
            base(UserFirstName, UserLastName, UserAccountNumber, UserCurrentBalance)
        {

        }
        public override void Deposit(decimal reservesDeposit)
        {
            UserCurrentBalance += reservesDeposit;
        }
        public override void Withdrawl(decimal reserveWithdrawl)
        {
            UserCurrentBalance -= reserveWithdrawl;
        }
    }
}