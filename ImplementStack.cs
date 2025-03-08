using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_Week5
{
    internal class ImplementStack<T>
    {
        private T[] stack;
        private int top;
        private int capacity;
        public ImplementStack(int size)
        {
            stack = new T[size];
            capacity = size;
            top = -1;
        }
        public bool IsEmpty()
        {
            return top == -1;
        }
        public void Push(T item)
        {
            if (top == capacity - 1)
            {
                throw new InvalidOperationException("Stack overflow");
            }
            stack[++top] = item;
        }
        public T Pop()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack underflow");
            }
            return stack[top--];
        }
        public T Peek()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return stack[top];
        }
        public int Count()
        {
            return top + 1;
        }
        public override string ToString()
        {
            return string.Join(", ", stack[0..(top + 1)]);
        }

        public static void GetStack()
        {
            ImplementStack<int> intStack = new ImplementStack<int>(5);
            while (true)
            {
                Console.WriteLine("\nChoose an operation:");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Peek");
                Console.WriteLine("4. Count");
                Console.WriteLine("5. Exit");
                int operation = int.Parse(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Enter an integer to push onto the stack:");
                        if (int.TryParse(Console.ReadLine(), out int number))
                        {
                            try
                            {
                                intStack.Push(number);
                                Console.WriteLine("Stack: " + intStack);
                                Console.WriteLine("Current count: " + intStack.Count());
                            }
                            catch (InvalidOperationException ex)
                            {
                                Console.WriteLine("Error: " + ex.Message);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        break;

                    case 2:
                        try
                        {
                            int poppedValue = intStack.Pop();
                            Console.WriteLine("Popped element: " + poppedValue);
                            Console.WriteLine("Stack after popping: " + intStack);
                            Console.WriteLine("Current count after popping: " + intStack.Count());
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case 3:
                        try
                        {
                            int topValue = intStack.Peek();
                            Console.WriteLine("Top element: " + topValue);
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                        break;

                    case 4:
                        Console.WriteLine("Current count: " + intStack.Count());
                        break;

                    case 5:
                        Console.WriteLine("Exiting the array stack operations.");
                        return;

                    default:
                        Console.WriteLine("Invalid operation. Please try again.");
                        break;
                }
            }
        }
    }
}
