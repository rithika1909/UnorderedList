using System;
using System.Net.NetworkInformation;
using UnorderedList.UnorderedList;
using UnorderedList.UnorderedListQueue;
using UnorderedList.UnorderedListStack;

namespace UnorderedList
{
    class Program
    {
        static string UnOrderedFilePath = @"D:\UnorderedList\UnorderedList\UnorderedList\UnorderedList.txt";
        static void Main(string[] args)
        {
            Operation operation = new Operation();
            operation.ReadFileAndPerformOperation(UnOrderedFilePath);
            Console.WriteLine("\nStack:");
            OperationStack operationStack = new OperationStack();
            operationStack.ReadFileAndPerformOperation(UnOrderedFilePath);
            Console.WriteLine("\nQueue:");
            OperationQueue operationqueue = new OperationQueue();
            operationqueue.ReadFileAndPerformOperation(UnOrderedFilePath);

        }
    }
}
