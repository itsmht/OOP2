﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Savings:Account
    {
        private int minBalance = 430;
        public Savings()
        {

        }
        public Savings(int accountID, string accountName, int balance) : base(accountID, accountName, balance)
        {

        }
        public void Transfer(int amount, Account acc)
        {
            if ((base.accB - amount) >= minBalance)
                base.Transfer(amount, acc);
            else
                Console.WriteLine("Insufficient Balance."); 
        } 
    }
}
