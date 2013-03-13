using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
    class IndividualCustomer : Customer
    {
        private string identityCardNumber;
        public string IdentityCardNumber
        {
            get
            {
                return this.identityCardNumber;
            }
            set
            {
                this.identityCardNumber = value;
            }
        }

        public override string Mail
        {
            get
            {
                return this.mail;
            }
            set
            {
                this.mail = value;
            }
        }

        public override string Phone
        {
            get
            {
                return this.phone;
            }
            set
            {
                this.phone = value;
            }
        }

        public override string Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }

        public override string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public IndividualCustomer() { }
        public IndividualCustomer(string name, string identityCardNumber) : this(name, identityCardNumber, "", "", "") { }
        public IndividualCustomer(string name, string identityCardNumber, string address, string phone, string mail)
        {
            this.mail = mail;
            this.phone = phone;
            this.address = address;
            this.identityCardNumber = identityCardNumber;
            this.name = name;
        }
    }
}
