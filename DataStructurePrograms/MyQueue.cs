using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    public class MyQueue<T>
    {
        public Node<T> head = null;
        public void Enqueue(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.nextNode != null)
                {
                    temp = temp.nextNode;
                }
                temp.nextNode = node;
            }
        }
        public void DisplayQueue()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.nextNode;
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            head = head.nextNode;
        }
        public void EmptyQueue()
        {
            while(head != null)
            {
                head = head.nextNode;
            }
        }
    }
}
