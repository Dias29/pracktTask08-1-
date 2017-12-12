using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexators
{
    class FailSoftArray
    {
        int[] a; // ссылка на базовый массив
        public int Length; // открытая переменная длины массива
        public bool ErrFlag; // обозначает результат последней операции

        // Построить массив заданного размера.
        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }
        
        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                  //  ErrFlag = false;
                    return a[index];
                }
                else
                {
                   // ErrFlag = true;
                    return 0;
                }
            }
            set
            {
                if (ok(index))
                {
                   a[index] = value;
                   // ErrFlag = false;
                }
                else ErrFlag = true;
            }
        }
        private bool ok(int index)
        {
            if (index >= 0 & index < Length) return true;
            return false;
        }
    }
}
