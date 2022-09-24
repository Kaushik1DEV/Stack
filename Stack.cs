using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class Stack<T> where T : class
    {
        private IList<T> stack;
        private int top;

        public Stack()
        {
            stack = new List<T>();
            top = - 1;
        }

        public void push(T value)
        {
          ++top;
          stack.Add(value);
        }

        public T pop()
        {
            if (top == -1) throw new Exception("stack underflow");

            T value = stack[top];
            stack.RemoveAt(top);
            top--;
            return value;
        }

        public T GetTop()
        {
            return stack[top];
        }

        public int size()
        {
            return top + 1;
        }

    }
}
