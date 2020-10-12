using System;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void array()
        {
            int[] myIntArray = { 1, 2, 4, 7, 11, 15, 19, 24, 30, 37 };
            Console.WriteLine("Give me a number: ");
            int t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < myIntArray.Length; i++)
            {
                if (t == myIntArray[i])
                {
                    Console.WriteLine("\n Your number is in the array \n");
                }
            }
            for (int j = 0; j < myIntArray.Length; j++)
            {
                Console.WriteLine(myIntArray[j]);
            }

        }

        static void stack()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(3);
            myStack.Push(6);
            myStack.Push(10);
            myStack.Push(15);
            myStack.Push(21);
            myStack.Push(28);
            myStack.Push(36);
            myStack.Push(45);
            myStack.Push(55);

            Console.WriteLine("Give me a number: ");
            int t = Convert.ToInt32(Console.ReadLine());

            if (myStack.Contains(t))
            {
                Console.WriteLine("\n Your number is in the stack \n");
            }
            else Console.WriteLine("\n Your number is not in the stack \n");

            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }
        }

        
        static void queues()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(3);
            callerIds.Enqueue(6);
            callerIds.Enqueue(10);
            callerIds.Enqueue(14);
            callerIds.Enqueue(19);
            callerIds.Enqueue(25);
            callerIds.Enqueue(31);
            callerIds.Enqueue(38);
            callerIds.Enqueue(46);

            Console.WriteLine("Give me a number: ");
            int t = Convert.ToInt32(Console.ReadLine());

            if (callerIds.Contains(t))
            {
                Console.WriteLine("\n Your number is in the queue \n");
            }
            else Console.WriteLine("\n Your number is not in the queue \n");


            foreach (var id in callerIds)
                Console.WriteLine(id);
        }

        static void list()
        {
            List<int> primeNumbers = new List<int>();
            primeNumbers.Add(1); 
            primeNumbers.Add(3);
            primeNumbers.Add(5);
            primeNumbers.Add(7);
            primeNumbers.Add(11);
            primeNumbers.Add(13); 
            primeNumbers.Add(17);
            primeNumbers.Add(19);
            primeNumbers.Add(23);
            primeNumbers.Add(29);

            Console.WriteLine("Give me a number: ");
            int t = Convert.ToInt32(Console.ReadLine());

            if (primeNumbers.Contains(t))
            {
                Console.WriteLine("\n Your number is in the list \n");
            }
            else Console.WriteLine("\n Your number is not in the list \n");


            foreach (var id in primeNumbers)
                Console.WriteLine(id);
        }

        static void Main(string[] args)
        {
            list();
        }
    }
}
