using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Person
    {
        private string name;
        private uint? age;

        public uint? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string Name
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
        public Person(string name, uint? age = null)
        {
            this.name = name;
            this.age = age;
        }
        public override string ToString()
        {
            if (age != null)
            {
                return string.Format("{0} is {1} years old.", name, age);
            }
            else
            {
                return string.Format("{0}`s age is not set.", name);
            }
        }
    }
}
