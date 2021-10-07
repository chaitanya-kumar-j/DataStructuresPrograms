using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    public class MyStack<T>
    {
        public Node<T> top;
        public MyStack()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top != null)
            {
                node.nextNode = this.top;
            }
            else
            {
                node.nextNode = null;
            }
            this.top = node;
        }
        public void DisplayStack()
        {
            Node<T> temp = this.top;
            if (temp == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextNode;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            Console.WriteLine($"Top element is: {this.top.data}");
        }
        public void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            this.top = this.top.nextNode;
        }
        public void MakeEmpty()
        {
            while(this.top != null)
            {
                Peek();
                Pop();
            }
        }
        public bool isEmpty()
        {
            if (this.top == null)
            {
                return true;
            }
            return false;
        }
    }
}
