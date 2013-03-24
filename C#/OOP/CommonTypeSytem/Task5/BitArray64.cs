using System;
using System.Collections.Generic;
using System.Linq;

namespace Task5
{
    class BitArray64 : IEnumerable<int>
    {
        private ulong bits;
        //constructor
        public BitArray64(ulong num)
        {
            this.bits = num;
        }
        //enumerator
        public IEnumerator<int> GetEnumerator()
        {
            int[] bitsArray = this.ConvertBitsToArray();
            for (int i = 63; i >= 0; i--)
            {
                yield return bitsArray[i];
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        //overrided methods
        public override bool Equals(object obj)
        {
            BitArray64 result = obj as BitArray64;
            if (result != null)
            {
                return this.bits == result.bits;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.bits.GetHashCode();
        }
        public static bool operator ==(BitArray64 a, BitArray64 b)
        {
            return BitArray64.Equals(a, b);
        }
        public static bool operator !=(BitArray64 a, BitArray64 b)
        {
            return !BitArray64.Equals(a, b);
        }
        //indexer
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
        private int[] ConvertBitsToArray()
        {
            int[] result = new int[64];
            ulong temp = this.bits;
            for (int i = 0; i < 64; i++)
            {
                result[i] = (int)(temp % 2);
                temp /= 2;
            }
            return result;
        }
    }
}
