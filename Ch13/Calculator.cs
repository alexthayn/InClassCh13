﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ch13
{
    public class Calculator : INotifyPropertyChanged
    {
        private Queue<int> numbers;

        public Calculator()
        {
            numbers = new Queue<int>();
        }

        public void EnterNumber(int number)
        {
            numbers.Enqueue(number);
        }

        public void Add()
        {
            Result = numbers.Sum();
            numbers.Clear();
        }

        public void Subtract()
        {
            int r = numbers.Dequeue();
            foreach(int i in numbers)
            {
                r = r - i;
            }
            Result = r;

            numbers.Clear();
        }

        public void Multiply()
        {
            int r = numbers.Dequeue();
            foreach (int i in numbers)
            {
                r = r*i;
            }
            Result = r;

            numbers.Clear();
        }

        private int result;
        public int Result
        {
            get { return result; }
            set { SetField(ref result, value); }
        }
                       
        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetField<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        #endregion

    }
}
