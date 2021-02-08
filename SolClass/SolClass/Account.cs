using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolClass
{
    class Account
    {
        private String accName;
        private String acid;
        private int balance;


        public Account(String acc, String acd, int bal)
        {
            accName = acc;
            acid = acd;
            balance = bal;
        }
        public void Deposit(int amount){
            balance = amount + balance;
            Console.WriteLine("Balance after deposit = " + balance);
        }
        public void Withdraw(int amount)
        {
            balance = balance - amount;
            Console.WriteLine("Balance after withraw = " + balance);
        }
        
    }
}
