using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
    class Loan : CustomerAcount
    {
        public Loan(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }

        public override decimal CalcInterestAmount(int periodInMonths)
        {

            if (CurrentCustomer is Company)
            {
                if (DateTime.Now - (accountCreationDate.AddMonths(2)) <= new TimeSpan(0))
                {
                    return 0;
                }
                else
                {
                    return periodInMonths * interestRate;
                }
            }
            else if (CurrentCustomer is IndividualCustomer)
            {
                if (DateTime.Now - (accountCreationDate.AddMonths(3)) <= new TimeSpan(0))
                {
                    return 0;
                }
                else
                {
                    return periodInMonths * interestRate;
                }

            }
            else 
            {
                return periodInMonths * interestRate;
            }
        }
    }
}
