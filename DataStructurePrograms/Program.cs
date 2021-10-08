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
                    "(1. Unordered List, 2. Ordered List, 3. Balanced Parentheses, 4. Bank cash counter)");
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
                    case 4:
                        
                        MyQueue<string> customerQueue = new MyQueue<string>();
                        BankCashCounter cashCounter = new BankCashCounter();
                        cashCounter.AddPeopleToQueue(customerQueue);
                        while(customerQueue.head != null)
                        {
                            string customer = customerQueue.head.data;
                            string customerName = customer.Split("-")[0];
                            int customerBalance = Convert.ToInt32(customer.Split("-")[1]);
                            bool isDoNextTransaction = true;
                            while (isDoNextTransaction)
                            {
                                Console.WriteLine($"{customerName},\nSelect an option of transaction(1. Withdraw, 2. Deposit, 3. Check balance, 4. Exit): ");
                                int transactionOption = Convert.ToInt32(Console.ReadLine());
                                switch (transactionOption)
                                {
                                    case 1:
                                        cashCounter.WithDraw(customerName, customerBalance);
                                        break;
                                    case 2:
                                        cashCounter.Deposit(customerName, customerBalance);
                                        break;
                                    case 3:
                                        cashCounter.BalanceCheck(customerName, customerBalance);
                                        break;
                                    default:
                                        customerQueue.Dequeue();
                                        isDoNextTransaction = !isDoNextTransaction;
                                        break;
                                }
                            }
                            
                        }
                        break;
                    default:
                        isRun = !isRun;
                        break;
                }
            }
            
        }
    }
}
