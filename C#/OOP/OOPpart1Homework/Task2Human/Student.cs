using System;
using System.Linq;


namespace Task2Human
{
    class Student : Human
    {
        private string firstName;
        private string lastName;
        private uint grade;
        public uint Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                this.grade = value;
            }
        }
        public Student() : this("Unknown", "Unknown") { }
        public Student(string firstName, string lastName) : this(firstName, lastName, 0) { }
        public Student(string firstName, string lastName, uint grade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.grade = grade;
        }
        public override string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public override string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        public override string ToString()
        {
            return string.Format("{0} {1} has grade: {2}", firstName, lastName, grade);
        }

    }
}
