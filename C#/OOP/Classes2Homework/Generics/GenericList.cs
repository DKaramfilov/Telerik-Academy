﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class GenericList<T> 
    {
        private T[] array;
        private int currentIndex = 0;
        private T defaultValue;

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

        public void Add(T obj)
        {
            if (currentIndex >= array.Length) array = DoubleSize();
            array[currentIndex] = obj;
            currentIndex++;
        }

        public void Insert(T obj, int index)
        {
            if (index > array.Length - 1) array = DoubleSize();

            
        }

        public void Remove(T obj)
        {
            int i = Array.IndexOf(array, obj);

            if (i < 0) throw new IndexOutOfRangeException();

            int lastIndex = 0;
            for (int j = i; j < array.Length-1; j++)
            {
                array[j] = array[j + 1];
                lastIndex = j;
            }
            array[lastIndex] = defaultValue;
            currentIndex--;
            
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < array.Length; i++)
            {
                result.Append(array[i]);
                result.Append(' ');
            }
            result.AppendLine();

            return result.ToString();
        }
  
    }
}
