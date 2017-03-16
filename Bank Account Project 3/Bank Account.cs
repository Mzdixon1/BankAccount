using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project_3

{
    class Bank_Account
    {
        private string userFirstName;
        private string userLastName;
        private double userAccountNumber;
        private decimal userCurrentBalance;




        public string UserFirstName
        {
            get { return userFirstName; }
            set { userFirstName = value; }
        }
        public string UserLastName
        {
            get { return userLastName; }
            set { userLastName = value; }

        }
        public double UserAccountNumber
        {
            get { return userAccountNumber; }
            set { userAccountNumber = value; }
        }

        public decimal UserCurrentBalance
        {
            get { return userCurrentBalance; }
            set { userCurrentBalance = value; }

        }

        public Bank_Account(string UserFirstName, string UserLastName, double UserAccountNumber, decimal UserCurrentBalance)

        {
            userFirstName = UserFirstName;
            userLastName = UserLastName;
            userAccountNumber = UserAccountNumber;
            userCurrentBalance = UserCurrentBalance;
        }
        public virtual void Deposit(decimal deposit)
        {
            UserCurrentBalance += deposit;

        }
        public virtual void Withdrawl(decimal withdrawl)
        {
            UserCurrentBalance -= withdrawl;
        }

    }
}

        
    

