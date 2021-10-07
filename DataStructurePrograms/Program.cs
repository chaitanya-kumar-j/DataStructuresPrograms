using System;
using DataStructuresPractice;

namespace DataStructurePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputFilePath = @"G:\BridgeLabz\DataStructuresPrograms\DataStructurePrograms\InputFile.txt";
            string outputFilePath = @"G:\BridgeLabz\DataStructuresPrograms\DataStructurePrograms\OutputFile.txt";
            new UnorderedList().UnorderListOperations(inputFilePath,outputFilePath);
        }
    }
}
