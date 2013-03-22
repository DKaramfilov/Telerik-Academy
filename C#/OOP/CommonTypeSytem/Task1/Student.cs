using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student: ICloneable, IComparable<Student>
    {
        private string firstName;
        private string lastName;
        private string middleName;
        private int SSN;
        private string address;
        private string mobilePhone;
        private string email;
        private Specialty specialty;
        private Faculty faculty;
        private University uni;

        public University Uni
        {
            get
            {
                return this.uni;
            }
            set
            {
                this.uni = value;
            }
        }
        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
            }
        }
        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }
        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                this.email = value;
            }
        }
        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                this.mobilePhone = value;
            }
        }
        public int Ssn
        {
            get
            {
                return this.SSN;
            }
            set
            {
                this.SSN = value;
            }
        }
        public string Address
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
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                this.middleName = value;
            }
        }
        public string LastName
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
        public string FirstName
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

        public Student(string firstName,string middleName,string lastName, int ssn)
        {
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            SSN = ssn;
        }
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", firstName, middleName,lastName, SSN);
        }
        public override bool Equals(object obj)
        {
            Student student = obj as Student;
            if (student == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, student.FirstName))
            {
                return false;
            }
            if (!Object.Equals(this.MiddleName, student.MiddleName))
            {
                return false;
            }
            if (!Object.Equals(this.LastName, student.LastName))
            {
                return false;
            }
            if (!Object.Equals(this.SSN, student.SSN))
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return SSN.GetHashCode();
        }
        public static bool operator ==(Student a, Student b)
        {
            return Student.Equals(a, b);
        }
        public static bool operator !=(Student a, Student b)
        {
            return !Student.Equals(a, b);
        }


        public object Clone()
        {
            Student stud = (Student)this.MemberwiseClone();
            return stud;
        }

        public int CompareTo(Student s)
        {
           
            int fname = this.firstName.CompareTo(s.firstName);
            int mName = this.middleName.CompareTo(s.middleName);
            int lname = this.lastName.CompareTo(s.lastName);

            if (fname != 0)
            {
                return fname;
            }
            else if(mName != 0)
            {
                return mName;
            }
            else if (lname != 0)
            {
                return lname;
            }
            else
            {
                return this.SSN.CompareTo(s.SSN);
            }
        }
    }
}
