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
        public void print()//Выводит все значения в массиве
        {
            foreach (int el in _arr)
                Console.Write(el + " ");
        }
        public int AllSum()//Складывает все значения в массиве
        {
            int sum = 0;
            foreach(int x in _arr)
                sum += x;
            return sum;
        }
        public long AllMul()// Умножает все значния в массиве
        {
            int sum = 0;
            foreach (int x in _arr)
                sum *= x;
            return sum;
        }
        public int Max()// Находит макисмальное значение в массиве
        {
            int max = 0;
            foreach (int x in _arr)
                if (max < x)
                    max = x;
            return max;
        }
        public int Min()// Находит минимальное значение в массиве
        {
            int min = 0;
            foreach (int x in _arr)
                if (min > x)
                    min = x;
            return min;
        }
        public int Average()//Находит среднее арифметическое
        {
            int ave = 0;
            foreach (int x in _arr)
                ave += x;
            ave = ave / _arr.Length;
            return ave;
        }
        public int FindInd(int value)//Если есть значение value возаращет его индекс в массиве
        {
            for(int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == value)
                    return i;
            }
            return -1;
        }
        public bool FindVal(int value)//Если есть значение value возвращает true или false
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == value)
                    return true;
            }
            return false;
        }
    }
}
