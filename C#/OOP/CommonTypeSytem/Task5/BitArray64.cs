using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bits;

        public IEnumerator<int> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
        }
        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
        }
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                return (bits & ((ulong)1 << index)) != 0 ? 1 : 0;
            }
            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException("Index must be in range [0, 63].");
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentOutOfRangeException("value", "Value must be 0 or 1.");
                }


                if (value == 1)
                {
                    this.bits = this.bits | ((ulong)1 << index);
                }
                else
                {
                    this.bits = this.bits & (~((ulong)1 << index));
                }
            }
        }
    }
}
