using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
     class CustomerAcount
    {
        protected decimal balance;
        protected decimal interestRate;
        protected Customer currentCustomer;
        protected DateTime accountCreationDate;

        protected CustomerAcount() { }
        protected CustomerAcount(Customer customer, decimal balance, decimal interestRate)
        {
            this.currentCustomer = customer;
            this.balance = balance;
            this.interestRate = interestRate;
            accountCreationDate = DateTime.Now;
        }

        public DateTime AccountCreationDate 
        {                                   
            get
            {
                return this.accountCreationDate;
            }
            set                                           // this is only for testing purpose
            {                                             // otherwise shou be set to private set
                this.accountCreationDate = value;
            }
        }

        public Customer CurrentCustomer
        {
            get
            {
                return this.currentCustomer;
            }
            set
            {
                this.currentCustomer = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }
            set
            {
                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public void DepositMoney(decimal amount)
        {
            balance += amount;
        }

        public virtual decimal CalcInterestAmount(int periodInMonths)
        {
            return InterestRate * periodInMonths;
        } 
    }
}
