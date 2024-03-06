﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios43
{
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
            if ( _count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }

            return _values[0];
        }

        public void Print()
        {
            for (int i = 0; i < _count; i++)
            {
                Console.WriteLine(_values[i] + ", ");
            }
            if( _count > 0)
            {
                Console.WriteLine(_values[_count - 1]);
            }
        }

    }
}