using System;
using System.Linq;
using System.Text;


namespace Generics
{
    class GenericList<T> 
    {
        private T[] array;
        private int currentIndex = 0;
        private readonly T defaultValue;

        public GenericList(): this(10)
        {}
        public GenericList(int lenght)
        {
            array = new T[lenght];
        }

        private T[] DoubleSize()
        {
            T[] temp = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            return temp;
        }

        public T this[int i]
        {
            get
            {
                if (i >= array.Length || i < 0) throw new IndexOutOfRangeException("max curent index: " + (array.Length - 1));
                return array[i];
            }
            set
            {
                if (i >= array.Length || i < 0) throw new IndexOutOfRangeException("max curent index: "+(array.Length-1));
                array[i] = value;
            }
        }

        public void Add(T obj)
        {
            if (currentIndex >= array.Length) array = DoubleSize();       
            array[currentIndex] = obj;
            currentIndex++;
        }
        public void Insert(T obj, int index)
        {           
            if (currentIndex + 1 >= array.Length) array = DoubleSize();
            if (index > array.Length - 1) throw new IndexOutOfRangeException("Cannot insert item, try add Method Instead.");

            for (int i = array.Length-2; i >= index; i--)
            {
                T temp = array[i];
                array[i + 1] = temp;
            }
            array[index] = obj;
            currentIndex++;
        }
        public void Remove(T obj)
        {
            int i = Array.IndexOf(array, obj);

            if (i < 0) throw new IndexOutOfRangeException("Element not found.");

            int lastIndex = 0;
            for (int j = i; j < array.Length-1; j++)
            {
                array[j] = array[j + 1];
                lastIndex = j;
            }
            array[lastIndex] = defaultValue;
            currentIndex--;          
        }
        public void Clear()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = defaultValue;
            }
        }
        public int Find(T obj, int index = 0)
        {
            int i = Array.IndexOf(array, obj,index);
            return i;
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < currentIndex; i++)
            {
                result.Append(array[i]);
                result.Append("; ");
            }
            result.AppendLine();

            return result.ToString();
        }  
    }
}
