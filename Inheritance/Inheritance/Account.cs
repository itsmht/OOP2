using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Account
    {
        
      
        private int accountID;

        public int accId
        {
            get { return accountID; }
            set { accountID = value; }
        }
        private string accountName;

        public string accN
        {
            get { return accountName; }
            set { accountName = value; }
        }
        private int balance;

        public int accB
        {
            get { return balance; }
            set { balance = value; }
        }
        
        public Account()
        {

        }
        public Account(int accountID,string accountName, int balance)
        {
            this.accountID = accountID;
            this.accountName = accountName;
            this.balance = balance;
        }
        public void Transfer(int amount, Account acc)
        {
            if (balance > amount)
            {
                balance =balance - amount;
                acc.balance =acc.balance + amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

        }
        public void ShowInfo()
        {
            
            Console.WriteLine("Account Number : " + accountID);
            Console.WriteLine("Account Name : " + accountName);
            Console.WriteLine("Balance : " + balance);
        }
        
        
        


    }
}
