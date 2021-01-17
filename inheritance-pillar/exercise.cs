using System;
using System.Collections;

namespace DesignAStack
{
    public class Stack
    {
        private readonly ArrayList _storage = new ArrayList();
        
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Can't store a null value inside the stack.");
            _storage.Add(obj);
        }

        public object Pop()
        {
            if (_storage.Count == 0)
                throw new InvalidOperationException("The stack is empty.");
            var index = _storage.Count;
            var element = _storage[index - 1];
            _storage.Remove(element);
            return element;
        }

        public void Clear()
        {
            _storage.Clear();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());
            System.Console.WriteLine(stack.Pop());

            System.Console.WriteLine("End of the show.");
        }
    }
}
