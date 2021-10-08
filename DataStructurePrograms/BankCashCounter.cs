using DataStructuresPractice;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructurePrograms
{
    class BankCashCounter
    {
        int bankBalance = 100000;
        const int WITHDRAW_LIMIT = 5000;
        public void AddPeopleToQueue(MyQueue<string> customerQueue)
        {
            bool isEnterQueue = true;
            while (isEnterQueue)
            {
                Console.WriteLine("Present list of customers in queue is: ");
                customerQueue.DisplayQueue();
                Console.WriteLine("\nIs a customer waiting to enter queue? \n " +
                    "Select 1. To enter and join queue, 2. To stop adding to queue");
                int entryOption = Convert.ToInt32(Console.ReadLine());
                switch (entryOption)
                {
                    case 1:
                        Customer customer = new Customer();
                        Console.WriteLine("Enter name and wait in Queue: ");
                        customer.CustomerName = Console.ReadLine();
                        Console.WriteLine($"Enter opening balance of {customer.CustomerName}: ");
                        customer.CustomerBalance = Convert.ToInt32(Console.ReadLine());
                        customerQueue.Enqueue(customer.CustomerName+"-"+customer.CustomerBalance);
                        break;
                    default:
                        isEnterQueue = !isEnterQueue;
                        break;
                }
            }
        }
        public void WithDraw(string customerName, int customerBalance)
        {
            Console.WriteLine("Enter the amount to withdraw: ");
            int withdrawAmount = Convert.ToInt32(Console.ReadLine());
            while (withdrawAmount > bankBalance)
            {
                Console.WriteLine("Bank balance is less than requested amount.");
                Console.WriteLine("Enter less amount..");
                withdrawAmount = Convert.ToInt32(Console.ReadLine());
            }
            while (withdrawAmount > customerBalance)
            {
                Console.WriteLine("Your account balance is less than requested amount.");
                Console.WriteLine("Enter less amount..");
                withdrawAmount = Convert.ToInt32(Console.ReadLine());
            }
            while (withdrawAmount > WITHDRAW_LIMIT)
            {
                Console.WriteLine("Requested amount is morethan withdraw limit per transaction.");
                Console.WriteLine("Enter less amount..");
                withdrawAmount = Convert.ToInt32(Console.ReadLine());
            }
            customerBalance -= withdrawAmount;
            bankBalance -= withdrawAmount;
            Console.WriteLine($"Account Balance of {customerName}, after withdraw of {withdrawAmount} is {customerBalance} and \n" +
                $"Bank balance is{bankBalance}");
        }
        public void Deposit(string customerName, int customerBalance)
        {
            Console.WriteLine("Enter the amount to Deposit: ");
            int depositAmount = Convert.ToInt32(Console.ReadLine());
            customerBalance += depositAmount;
            bankBalance += depositAmount;
            Console.WriteLine($"Account Balance of {customerName}, after deposit of {depositAmount} is {customerBalance} and \n" +
                $"Bank balance is{bankBalance}");
        }
        public void BalanceCheck(string customerName, int customerBalance)
        {
            Console.WriteLine($"Account Balance of {customerName} is {customerBalance} and \n" +
                $"Bank balance is{bankBalance}");
        }
    }
    public class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerBalance { get; set; }
    }
}
