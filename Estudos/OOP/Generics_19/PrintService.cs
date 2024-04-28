using System;

namespace Generics_19
{
//Generics - permite o reuso da classe com diversos tipos, além de uma melhor performance, no exemplo abaixo o tipo
//<T> representa o tipo que a pessoa irá escolher para realizar a função, podendo ser desde int até string
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if (_count == 10)
            {
                throw new InvalidOperationException("PrintService is full");
            }

            _values[_count] = value;
            _count++;
        }

        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }

            Console.WriteLine("]");
        }
    }
}
