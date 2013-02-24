using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    class Matrix<T>// where T : INumeralOperators
    {
        private T[,] matrix;

        public Matrix(int p)
            : this(p, p)
        { }
        public Matrix(int row, int col)
        {
            matrix = new T[row, col];
        }
        public int GetLength(int dimension)
        {
            return matrix.GetLength(dimension);
        }
        public static Matrix<T> operator +(Matrix<T>  a , Matrix<T> b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new SystemException("Matrixes Dimensions are not equal");

            Matrix<T> temp = new Matrix<T>(a.GetLength(0), a.GetLength(1));

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    temp[row, col] = (dynamic)a[row, col] + b[row, col];
                }
            }
            return temp;
        }
        public static Matrix<T> operator -(Matrix<T> a, Matrix<T> b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new SystemException("Matrixes Dimensions are not equal");

            Matrix<T> temp = new Matrix<T>(a.GetLength(0), a.GetLength(1));

            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    temp[row, col] = (dynamic)a[row, col] - b[row, col];
                }
            }
            return temp;
        }
        public static Matrix<T> operator *(Matrix<T> a, Matrix<T> b)
        {
            if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
                throw new SystemException("Matrixes Dimensions are not equal");

            Matrix<T> temp = new Matrix<T>(a.GetLength(0), a.GetLength(1));
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    for (int i = 0; i < a.GetLength(1); i++)
                    {
                        temp[row, col] += (dynamic)a[i, col] * b[row, i];
                    }

                }
            }
            return temp;
        }
        public static Boolean operator true(Matrix<T> a)
        {
            T zero = default(T);
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if ((dynamic)a[row, col] == zero) return false;
                }
            }
            return true;
        }
        public static Boolean operator false(Matrix<T> a)
        {
            T zero = default(T);
            for (int row = 0; row < a.GetLength(0); row++)
            {
                for (int col = 0; col < a.GetLength(1); col++)
                {
                    if ((dynamic)a[row, col] == zero) return true;
                }
            }
            return false;
        }

        public T this[int x, int y]
        {
            get
            {
                if ((x >= matrix.GetLength(0) || x < 0) || (y >= matrix.GetLength(1) || y < 0))
                    throw new IndexOutOfRangeException();
                return matrix[x, y];
            }
            set
            {
                if ((x >= matrix.GetLength(0) || x < 0) || (y >= matrix.GetLength(1) || y < 0))
                    throw new IndexOutOfRangeException();
                matrix[x, y] = value;
            }
        }

        public override string ToString()
        {

            string temp = "";

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    temp += matrix[row, col].ToString() + (col != matrix.GetLength(1) - 1 ? " " : "\n");
                }
            }
            return temp;
        }
    }
}
