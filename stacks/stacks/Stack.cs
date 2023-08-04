﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacks
{
    public class Stack<T>
    {
        private readonly IStack<T> stack;
        public int Count => stack.Count;

        public Stack(StackType type = StackType.Array)
        {
            if (type == StackType.Array)
            {
                stack = new ArrayStack<T>();
            }
            else
            {
                stack = new LinkedListStack<T>();
            }
        }

        public T Pop()
        {
            return stack.Pop();
        }

        public T Peek() 
        { 
            return stack.Peek();
        }

        public void Push(T value)
        {
            stack.Push(value);
        }
    }

    public interface IStack<T> 
    {
        int Count { get; }
        void Push(T value);
        T Peek();
        T Pop();
    }

    public enum StackType
    {
        Array = 0,          // List<T> - Dynamic Array
        LinkedList = 1,     // LinkedList<T>
    }
}
