using System;
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
        {}
        public Call(string dialedNumber):this(dialedNumber,0)
        {}
        public Call(string dialedNumber, int duration):this(dialedNumber,duration,new DateTime())
        {}
        public Call(string dialedNumber, int duration, DateTime dialedAt)
        {
            this.DialedAt = dialedAt;
            this.Duration = duration;
            this.DialedNumber = dialedNumber;
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
