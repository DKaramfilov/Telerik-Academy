using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstNationalTalerikBank
{
    class Bank
    {
        private decimal overallBankBalance;
        private static int customerAcountId = 0;
        private Dictionary<int ,CustomerAcount> currentBankAcounts = new Dictionary<int,CustomerAcount>();

        public Dictionary<int, CustomerAcount> CurrentBankAcounts
        {
            get
            {
                return this.currentBankAcounts;
            }
            private set
            {
                this.currentBankAcounts = value;
            }
        }

        public decimal OverallBankBalance
        {
            get
            {
                return this.overallBankBalance;
            }
            private set
            {
                this.overallBankBalance = value;
            }
        }

        public Bank(decimal balance)
        {
            overallBankBalance = balance;
        }
        public void AddAcount(CustomerAcount account)
        {
            currentBankAcounts.Add(customerAcountId, account);
            overallBankBalance += account.Balance;
            customerAcountId++;
        }
    }
}
