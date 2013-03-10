using System;
using System.Linq;


namespace Task2Human
{
    class Worker : Human
    {
        private string firstName;
        private string lastName;
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker() : this("Unknown", "Unknown") { }
        public Worker(string firstName, string lastName) : this(firstName, lastName, 0, 0) { }
        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                this.workHoursPerDay = value;
            }
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                this.weekSalary = value;
            }
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

        public decimal MoneyPerHour()
        {
            return weekSalary / (workHoursPerDay * 7);
        }

        public override string ToString()
        {
            return string.Format("{0} {1} recieves : {2:C} per hour.", firstName, lastName, MoneyPerHour());
        }
    }


}
