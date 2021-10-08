using DataStructuresPractice;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms.Deque
{
    class MyDeque<T>
    {
        public Node<T> head = null;
        public void AddFront(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node<T> temp = this.head;
                head = newNode;
                head.nextNode = temp;
            }
        }
        public void AddRear(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
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
        public void DisplayDeque()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Deque is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextNode;
            }
        }
        public void RemoveFront()
        {
            if (this.head == null)
            {
                head = null;
            }
            this.head = this.head.nextNode;
        }
        public void RemoveRear()
        {
            if (head == null)
            {
                Console.WriteLine("List is Empty.");
                return;
            }
            Node<T> temp = head;
            while (temp.nextNode.nextNode != null)
            {
                temp = temp.nextNode;
            }
            temp.nextNode = null;
        }
        public bool isEmpty()
        {
            return head.Equals(null);
        }
        public int Size()
        {
            int count = 0;
            Node<T> temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.nextNode;
            }
            return count;
        }
        public bool isEqual(MyDeque<T> deque)
        {
            Node<T> temp1 = this.head;
            Node<T> temp2 = deque.head;
            while (temp1 != null )
            {
                if(temp1.data.Equals(temp2.data))
                {
                    temp1 = temp1.nextNode;
                    temp2 = temp2.nextNode;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
