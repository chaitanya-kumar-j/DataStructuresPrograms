using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    public class MyLinkedList<T>
    {
        public Node<T> head;
        public void AddNode(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node<T> temp = head;
                while(temp.nextNode != null)
                {
                    temp = temp.nextNode;
                }
                temp.nextNode = node;
            }
        }
        public void DisplayList()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.nextNode;
            }
        }
        public void AddInReverseOrder(T data)
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
        public void AddInBetween(T data, int position)
        {
            Node<T> newestNode = new Node<T>(data);
            if(this.head == null)
            {
                this.head =  newestNode;
            }
            if (position == 0)
            {
                newestNode.nextNode = this.head;
                this.head = newestNode;
            }
            Node<T> prev = null;
            Node<T> current = this.head;
            int count = 0;
            while(current!=null && count < position)
            {
                prev = current;
                current = current.nextNode;
                count++;
            }
            newestNode.nextNode = prev.nextNode;
            prev.nextNode = newestNode;
        }
        public void RemoveFirstNode()
        {
            if(this.head == null)
            {
                head = null;
            }
            this.head = this.head.nextNode;
        }
        public void RemoveLastNode()
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
        public int Search(T value)
        {
            if (head == null)
            {
                Console.WriteLine("list is Empty");
                return -1;
            }
            int count = 0;
            Node<T> temp = this.head;
            while (!temp.data.Equals(value))
            {
                count++;
                temp = temp.nextNode;
            }
            return count;
        }
        public void AddAfterNumber(T oldValue, T newValue)
        {
            int position = this.Search(oldValue);
            this.AddInBetween(newValue, position+1);
        }
        public MyLinkedList<T> SortList()
        {
            List<T> outputList = this.LinkedListToList();
            outputList.Sort();
            MyLinkedList<T> sortedList = new MyLinkedList<T>();
            foreach (T element in outputList)
            {
                sortedList.AddNode(element);
            }
            return sortedList;
        }
        public int Size()
        {
            int count = 0;
            while(this.head != null)
            {
                count++;
                head = head.nextNode;
            }
            return count;
        }
        public void DeleteANumber(T value)
        {
            int position = this.Search(value);
            Node<T> temp = this.head;
            Node<T> prev = this.head;
            if (temp.data.Equals(null))
            {
                Console.WriteLine("List is empty.");
                return;
            }
            else if (temp.data.Equals(value))
            {
                head = temp.nextNode;
                return;
            }
            else
            {
                while (!temp.data.Equals(null))
                {
                    if (temp.data.Equals(value))
                    {
                        prev.nextNode = temp.nextNode;
                        return;
                    }
                    prev = temp;
                    temp = temp.nextNode;
                }
                if (temp.Equals(null))
                {
                    Console.WriteLine("Not found in list");
                }
            }
        }

        public List<T> LinkedListToList()
        {
            List<T> tempList = new List<T>();
            Node<T> temp = this.head;
            if (temp == null)
            {
                return tempList;
            }
            while (temp != null)
            {
                tempList.Add(temp.data);
                temp = temp.nextNode;
            }
            return tempList;
        }
    }
}
