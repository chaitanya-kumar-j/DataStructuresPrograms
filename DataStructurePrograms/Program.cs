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
            string equationFilePath = @"G:\BridgeLabz\DataStructuresPrograms\DataStructurePrograms\Equation.txt";
            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("Select and enter program number:" +
                    "(1. Unordered List, 2. Ordered List, 3. Balanced Parentheses");
                int programOption = Convert.ToInt32(Console.ReadLine());
                switch (programOption)
                {
                    case 1:
                        new UnorderedList().UnorderListOperations(inputFilePath, outputFilePath);
                        break;
                    case 2:
                        new OderedList().OrderedListOperations(inputFilePath, outputFilePath);
                        break;
                    case 3:
                        new BalancedParentheses().isBalancedParentheses(equationFilePath);
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
            
        }
    }
}
