using System;
using System.Collections.Generic;
using DataStructuresPractice;
using System.IO;
using System.Text;

namespace DataStructurePrograms
{
    public class UnorderedList
    {
        public void UnorderListOperations(string inputFilePath, string outputFilePath)
        {
            string[] wordsList = File.ReadAllText(inputFilePath).Split(",");
            MyLinkedList<string> listOfWords = new MyLinkedList<string>();
            foreach(string word in wordsList)
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
            List<string> outputList = listOfWords.LinkedListToList();
            string output = "";
            foreach(string word in outputList)
            {
                output = output+"," + word;
            }
            output.Remove(0);
            File.WriteAllText(outputFilePath, output);
        }
    }
}
