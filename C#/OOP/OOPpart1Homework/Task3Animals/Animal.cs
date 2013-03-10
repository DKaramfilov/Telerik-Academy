using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3Animals
{
    abstract class Animal
    {
        private string name;
        private int age;
        protected GenderType gender;

        public Animal() : this("Unknown", 0) { }
        public Animal(string name, int age) : this(name, age, GenderType.Unknown) { }
        public Animal(string name, int age, GenderType gender)
        {
            this.gender = gender;
            this.age = age;
            this.name = name;
        }

        public virtual GenderType Gender
        {
            get
            {
                return this.gender;
            }
            protected set
            {
                this.gender = value;
            }
        }

        public int Age
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

        public abstract void SetGender(GenderType gender);
       
    }
}
