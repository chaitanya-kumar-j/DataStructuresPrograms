using DataStructuresPractice;
using System;
using System.Collections.Generic;

namespace DataStructurePrograms
{
    public class HashingFunction
    {
        public void Hashing(int[] inputNumbers)
        {
            Console.WriteLine("List of numbers passing are: ");
            foreach (int number in inputNumbers)
            {
                Console.Write(number+" ");
            }
            int slotSize = 10;
            int hashingNumber = 11;
            List<MyLinkedList<int>> mySlotList = new List<MyLinkedList<int>>();
            mySlotList.Add(new MyLinkedList<int>());
            foreach (int number in inputNumbers)
            {
                int hashValue = number % hashingNumber;
                if (hashValue > mySlotList.Count - 1)
                {
                    HashingUpdate(number, hashingNumber, mySlotList);
                }
                else
                {
                    if (mySlotList[hashValue].Search(number) >= 0)
                    {
                        mySlotList[hashValue].DeleteANumber(number);
                    }
                    else
                    {
                        mySlotList[hashValue].AddNode(number);
                    }
                }
            }
            for(int i = 0; i<mySlotList.Count;i++)
            {
                Console.WriteLine($"\nSlot{i} values are:");
                mySlotList[i].DisplayList();
            }
        }
        public void HashingUpdate(int number,int hashingNumber, List<MyLinkedList<int>> slotList)
        {
            int slotSize = slotList.Count;
            int hashValue = number % hashingNumber;
            if (hashValue > slotSize-1)
            {
                for(int i = slotSize; i <= hashValue; i++)
                {
                    slotList.Add(new MyLinkedList<int>());
                }
                slotList[hashValue].AddNode(number);
            }
            else
            {
                int position = slotList[hashValue].Search(number);
                if(position >= 0)
                {
                    slotList[hashValue].DeleteANumber(number);
                }
                else
                {
                    slotList[hashValue].AddNode(number);
                }
            }
        }
    }
}