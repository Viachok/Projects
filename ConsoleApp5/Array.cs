using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Array
    {
        int[] _arr;
        public Array()
        {
            _arr = new int[10];
            for (int i = 0; i < 10; i++)
                _arr[i] = 0;
        }
        public Array(int index)
        {
            _arr = new int[index];
            for (int i = 0; i < index; i++)
                _arr[i] = 0;
        }
        public void print()
        {
            foreach (int el in _arr)
                Console.Write(el + " ");
        }
        public int AllSum()
        {
            int sum = 0;
            foreach(int x in _arr)
                sum += x;
            return sum;
        }
        public int AllMul()
        {
            int sum = 0;
            foreach (int x in _arr)
                sum *= x;
            return sum;
        }
        public int Max()
        {
            int max = 0;
            foreach (int x in _arr)
                if (max < x)
                    max = x;
            return max;
        }
        public int Min()
        {
            int min = 0;
            foreach (int x in _arr)
                if (min > x)
                    min = x;
            return min;
        }
        public int Average()
        {
            int ave = 0;
            foreach (int x in _arr)
                ave += x;
            ave = ave / _arr.Length;
            return ave;
        }
        public int FindInd(int index)
        {
            for(int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == index)
                    return i;
            }
                    return -1;
        }
        public bool find
    }
}
