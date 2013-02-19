using System;
using System.Collections.Generic;
using System.Linq;


namespace Classes1Homework
{
    class Call : IComparable<Call>
    {
        private string dialedNumber;
        private int duration;
        private DateTime dialedAt;

        public DateTime DialedAt
        {
            get
            {
                return this.dialedAt;
            }
            set
            {
                this.dialedAt = value;
            }
        }

        public int Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
            }
        }
        public string DialedNumber
        {
            get
            {
                return this.dialedNumber;
            }
            set
            {
                this.dialedNumber = value;
            }
        }

        public Call()
        {
            this.dialedAt = new DateTime();
            this.duration = 0;
            this.dialedNumber = null;
        }
        public Call(string dialedNumber)
        {
            this.dialedAt = new DateTime();
            this.duration = 0;
            this.dialedNumber = dialedNumber;
        }
        public Call(string dialedNumber, int duration)
        {
            this.dialedAt = new DateTime();
            this.duration = duration;
            this.dialedNumber = dialedNumber;
        }
        public Call(string dialedNumber, int duration, DateTime dialedAt)
        {
            this.dialedAt = dialedAt;
            this.duration = duration;
            this.dialedNumber = dialedNumber;
        }

        public int CompareTo(Call other)
        {
            if (this.duration < other.duration)
            {
                return -1;
            }
            else if (this.duration == other.duration)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
