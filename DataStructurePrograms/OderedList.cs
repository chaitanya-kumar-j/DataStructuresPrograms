using DataStructuresPractice;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructurePrograms
{
    public class OderedList
    {
        public void OrderedListOperations(string inputFilePath, string outputFilePath)
        {
            string[] wordsList = File.ReadAllText(inputFilePath).Split(",");
            MyLinkedList<string> listOfWords = new MyLinkedList<string>();
            foreach (string word in wordsList)
            {
                listOfWords.AddNode(word);
            }
            bool isEdit = true;
            while (isEdit)
            {
                Console.WriteLine("Enter 1 to edit data, 2 to exit");
                int editOption = Convert.ToInt32(Console.ReadLine());
                switch (editOption)
                {
                    case 1:
                        Console.WriteLine("Enter word to search: ");
                        string searchWord = Console.ReadLine();
                        int position = listOfWords.Search(searchWord);
                        if (position >= 0)
                        {
                            Console.WriteLine("Deleting the searched word...");
                            listOfWords.DeleteANumber(searchWord);
                        }
                        else
                        {
                            Console.WriteLine("Adding word to list");
                            listOfWords.AddNode(searchWord);
                        }
                        break;
                    default:
                        isEdit = !isEdit;
                        break;
                }
            }
            MyLinkedList<string> sortedList = listOfWords.SortList();
            List<string> outputList = sortedList.LinkedListToList();
            string a = "";
            foreach (string word in outputList)
            {
                a = a + "," + word;
            }
            string output = a.Remove(0,1);
            File.WriteAllText(outputFilePath, output);
        }
    }
}
