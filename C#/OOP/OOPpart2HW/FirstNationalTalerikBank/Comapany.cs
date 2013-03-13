using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstNationalTalerikBank
{
    class Company : Customer
    {
        private string bulstat;
        public string Bulstat
        {
            get
            {
                return this.bulstat;
            }
            set
            {
                this.bulstat = value;
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

        public Company() { }
        public Company(string name, string bulstat) : this(name, bulstat, "", "", "") { }
        public Company(string name, string bulstat, string address, string phone, string mail)
        {
            this.mail = mail;
            this.phone = phone;
            this.address = address;
            this.bulstat = bulstat;
            this.name = name;
        }
    }
}
