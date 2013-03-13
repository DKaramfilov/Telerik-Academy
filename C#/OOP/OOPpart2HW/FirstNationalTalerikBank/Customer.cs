using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
    abstract class Customer
    {
        protected string name;
        protected string address;
        protected string phone;
        protected string mail;


        public abstract string Mail
        {
            get;

            set;

        }

        public abstract string Phone
        {
            get;

            set;
        }

        public abstract string Address
        {
            get;

            set;
        }

        public abstract string Name
        {
            get;

            set;
        }
    }
}
