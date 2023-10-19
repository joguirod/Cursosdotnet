using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicios.Entities.Exceptions;

namespace Exercicios.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount) 
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (Balance < amount)
            {
                throw new DomainException("Your balance must be superior than the withdraw amount!");
            }

            else if (WithdrawLimit < amount) 
            {
                throw new DomainException("The withdraw amount must respect yout withdraw limit!");
            }

            Balance -= amount;
        }
    }
}
