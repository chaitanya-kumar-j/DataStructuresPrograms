using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    public class Queue
    {
        public Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.nextNode != null)
                {
                    temp = temp.nextNode;
                }
                temp.nextNode = node;
            }
        }
        public void DisplayQueue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
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
