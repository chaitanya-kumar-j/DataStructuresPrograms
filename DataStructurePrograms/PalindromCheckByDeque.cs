using DataStructurePrograms.Deque;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class PalindromCheckByDeque
    {
        public bool isPalindrome()
        {
            MyDeque<string> frontDeque = new MyDeque<string>();
            MyDeque<string> rearDeque = new MyDeque<string>();
            Console.WriteLine("Enter the word to check: ");
            char[] testWord = Console.ReadLine().ToCharArray();
            foreach (char ch in testWord)
            {
                frontDeque.AddFront(Convert.ToString(ch.ToString().ToLower()));
                rearDeque.AddRear(Convert.ToString(ch.ToString().ToLower()));
            }
            Console.WriteLine("front added Deque is: ");
            frontDeque.DisplayDeque();
            Console.WriteLine("\nRear added Deque is: ");
            rearDeque.DisplayDeque();
            if (frontDeque.isEqual(rearDeque))
            {
                Console.WriteLine("\nEntered string is Palindrome.");
                return true;
            }
            else
            {
                Console.WriteLine("\nEntered string is not Palindrome.");
                return false;
            }
        }
    }
}
