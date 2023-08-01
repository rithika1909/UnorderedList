using UnorderedList.OrderedList;
using System;
using System.Net.NetworkInformation;
using UnorderedList.UnorderedList;
using UnorderedList.UnorderedListQueue;
using UnorderedList.UnorderedListStack;
using UnorderedList.BankingCashierAccount;

namespace UnorderedList
{
    class Program
    {
        static string UnOrderedFilePath = @"D:\UnorderedList\UnorderedList\UnorderedList\UnorderedList.txt";
        static string OrderedFilePath = @"D:\UnorderedList\UnorderedList\OrderedList\OrderedList.txt";
        static string BalancedFilePath = @"D:\UnorderedList\UnorderedList\BalancedParanthesis\Balanced.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Enter the option to Execute\n1.UnorderedList\n2.Stack\n3.Queue\n4.Ordered List\n5.Balanced Paranthesis\n6.Banking Cashier Account\n7.Exit");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Operation operation = new Operation();
                        operation.ReadFileAndPerformOperation(UnOrderedFilePath);
                        break;
                    case 2:
                        Console.WriteLine("\nStack:");
                        OperationStack operationStack = new OperationStack();
                        operationStack.ReadFileAndPerformOperation(UnOrderedFilePath);
                        break;
                    case 3:
                        Console.WriteLine("\nQueue:");
                        OperationQueue operationqueue = new OperationQueue();
                        operationqueue.ReadFileAndPerformOperation(UnOrderedFilePath);
                        break;
                    case 4:
                        OperationOrdered operationOrdered = new OperationOrdered();
                        operationOrdered.ReadFileAndPerformOperation(OrderedFilePath);
                        break;
                    case 5:
                        OperationStack operationbalanced = new OperationStack();
                        operationbalanced.ReadFileAndPerformOperation(BalancedFilePath);
                        break;
                    case 6:
                         Operationbank bank = new Operationbank();
                         int amount = 0;
                         bank.Balance(amount);
                         bank.AddPersonsInQueue();
                         break;
                    case 7:
                        flag = false;
                        break;








                }

            }
       
           


        }
    }
}
