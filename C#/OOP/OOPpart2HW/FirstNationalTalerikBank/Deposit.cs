using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
    class Deposit : CustomerAcount
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate) : base(customer, balance, interestRate) { }
        public void WithDrawMoney(decimal amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("Not enought money!");                
            }
            else
            {
                balance -= amount;
            }
        }
        public override decimal CalcInterestAmount(int periodInMonths)
        {

            if ( balance<1001 && balance >0)
            {
                return 0;
            }
            else
            {
                return periodInMonths * interestRate;
            }
        }
    }
}
