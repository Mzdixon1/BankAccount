using System;
using System.Collections.Generic;
using System.Linq;  
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Checking_Account checking = new Checking_Account("Mary", "Jane", 515151, 1800);
            Savings_Account savings = new Savings_Account("Mary", "Jane", 525252, 1300);
            Reserve_Account reserve = new Reserve_Account("Mary", "Jane", 535353, 2000);
            Console.WriteLine("Welcome to We Got Your Money Bank");

            Console.WriteLine("Hi" + checking.UserFirstName);
            Console.WriteLine("Current Balances");
            Console.WriteLine("Checking Account: {0:C}", checking.UserCurrentBalance);
            Console.WriteLine("Savings Account: {0:C}", savings.UserCurrentBalance);
            Console.WriteLine("Reserve Account: {0:C}", reserve.UserCurrentBalance);

            Console.WriteLine("To view your Account Balance");
            Console.WriteLine("Press 1 for Checking");
            Console.WriteLine("Press 2 for Savings");
            Console.WriteLine("Press 3 for reserves");

            Console.WriteLine("To deposit funds");
            Console.WriteLine("Press 1 for Checking");
            Console.WriteLine("Press 2 for Savings");
            Console.WriteLine("Press 3 for reserves");

            Console.WriteLine("To Withdraw funds");
            Console.WriteLine("Press 4 for Checking");
            Console.WriteLine("Press 5 for Savings");
            Console.WriteLine("Press 6 for reserves");
            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine("enter the amount");
                decimal checkingDeposit = Convert.ToDecimal(Console.ReadLine());
                checking.Deposit(checkingDeposit);
                
            }
            else if (userInput == "2")
            {
                Console.WriteLine("enter the amount");
                decimal savingsDeposit = Convert.ToDecimal(Console.ReadLine());
                savings.Deposit(savingsDeposit);
            }
            else if (userInput == "3")
            {
                Console.WriteLine("enter the amount");
                decimal reservesDeposit = decimal.Parse(Console.ReadLine());
                reserve.Deposit(reservesDeposit);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }


            if (userInput == "4")
            {
                Console.WriteLine("enter the amount");
                decimal checkingWithdrawl = decimal.Parse(Console.ReadLine());
                checking.Withdrawl(checkingWithdrawl);

            }
            else if (userInput == "5")
            {
                Console.WriteLine("enter the amount");
                decimal savingsWithdrawl = decimal.Parse(Console.ReadLine());
                savings.Deposit(savingsWithdrawl);

            }
            else if (userInput == "6")
            {
                Console.WriteLine("enter the amount");
                decimal reservesWithdrawl = decimal.Parse(Console.ReadLine());
                reserve.Deposit(reservesWithdrawl);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }


            Console.WriteLine("To withdraw funds");
            Console.WriteLine("Press 1 for Checking");
            Console.WriteLine("Press 2 for Savings");
            Console.WriteLine("Press 3 for reserves");
            string userInput2 = Console.ReadLine();
        }
    }

}
