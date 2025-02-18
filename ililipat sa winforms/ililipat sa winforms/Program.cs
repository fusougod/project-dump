using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();
        Queue<int> queue = new Queue<int>();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Push to Stack");
            Console.WriteLine("2. Pop from Stack");
            Console.WriteLine("3. Display Stack");
            Console.WriteLine("4. Enqueue to Queue");
            Console.WriteLine("5. Dequeue from Queue");
            Console.WriteLine("6. Display Queue");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter number to push: ");
                    if (int.TryParse(Console.ReadLine(), out int stackNum))
                    {
                        stack.Push(stackNum);
                        Console.WriteLine("Pushed to stack.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "2":
                    if (stack.Count > 0)
                        Console.WriteLine("Popped from stack: " + stack.Pop());
                    else
                        Console.WriteLine("Stack is empty.");
                    break;
                case "3":
                    Console.WriteLine("Stack contents: " + string.Join(", ", stack));
                    break;
                case "4":
                    Console.Write("Enter number to enqueue: ");
                    if (int.TryParse(Console.ReadLine(), out int queueNum))
                    {
                        queue.Enqueue(queueNum);
                        Console.WriteLine("Enqueued to queue.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.");
                    }
                    break;
                case "5":
                    if (queue.Count > 0)
                        Console.WriteLine("Dequeued from queue: " + queue.Dequeue());
                    else
                        Console.WriteLine("Queue is empty.");
                    break;
                case "6":
                    Console.WriteLine("Queue contents: " + string.Join(", ", queue));
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
