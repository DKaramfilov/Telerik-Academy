using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
    class MainClass
    {
        public static List<Customer> customersDatabase = new List<Customer>();
        static void Main()
        {
            IntialiseCustomers();
            Bank BNB = new Bank(100000000);
            //test Mortgage
            BNB.AddAcount(new Mortgage(customersDatabase[0],1000,12));
            BNB.AddAcount(new Mortgage(customersDatabase[1], 1230, 9));


            BNB.CurrentBankAcounts[0].AccountCreationDate = new DateTime(2013, 1, 1);//for the test of calc interest function i am
            BNB.CurrentBankAcounts[1].AccountCreationDate = new DateTime(2010, 1, 1);//seting the date in and out of given period

            //test deposit

            BNB.AddAcount(new Deposit(customersDatabase[2], 300, 10));
            BNB.AddAcount(new Deposit(customersDatabase[4], 1233, 15));
            
            //test  loan
            BNB.AddAcount(new Loan(customersDatabase[3], 1233, 15));
            BNB.AddAcount(new Loan(customersDatabase[5], 1233, 15));
            BNB.CurrentBankAcounts[5].AccountCreationDate = new DateTime(2010, 1, 1);//set acount period for longer period to test interest method



            foreach (var account in BNB.CurrentBankAcounts)
            {
                Console.WriteLine("Account inerest:" + account.Value.CalcInterestAmount(1));
            }
            //test depozit method
            Console.WriteLine("-----------------------------------------------");
            foreach (var account in BNB.CurrentBankAcounts)
            {
                account.Value.DepositMoney(1000000000);
                Console.WriteLine("Curent balance: {0:C}",account.Value.Balance);
            }
 

            
        }
        public static void IntialiseCustomers()
        {
            customersDatabase.Add(new Company("Microsoft", "112212212"));
            customersDatabase.Add(new Company("Telerik", "112212212"));
            customersDatabase.Add(new Company("MPC", "112212212"));
            customersDatabase.Add(new Company("BMW", "112212212"));
            customersDatabase.Add(new IndividualCustomer("Gail Spring", "112212212"));
            customersDatabase.Add(new IndividualCustomer("Barbar Huie", "112212212"));
            customersDatabase.Add(new IndividualCustomer("Concha Bolin", "112212212"));
            customersDatabase.Add(new IndividualCustomer("Janee Pillar", "112212212"));
            customersDatabase.Add(new IndividualCustomer("Catina Carrel", "112212212"));

        }
    }
}
