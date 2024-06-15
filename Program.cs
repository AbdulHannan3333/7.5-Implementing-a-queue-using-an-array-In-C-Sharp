using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._5_Implementing_a_queue_using_an_array
{
    internal class Program
    {
        class QueueUsingArray 
        {
            private int maxSize;
            private int[] queueArray;
            private int front;
            private int rear;
            private int itemCount;
            public QueueUsingArray(int size) 
            {
                maxSize = size;
                queueArray = new int[maxSize];
                front = 0;
                rear = -1;
                itemCount = 0;
            }
            public void Enqueue(int value) 
            {
                if (itemCount < maxSize)
                {
                    if (rear == maxSize - 1)
                    {
                        rear = -1;
                    }
                    queueArray[++rear] = value;
                    itemCount++;
                }
                else 
                {
                    Console.WriteLine("Queue is full. Cannot Enqueue Element.");
                }
            }
            public int Dequeue() 
            {
                if (itemCount > 0)
                {
                    int dequeuedValue = queueArray[front++];
                    if (front == maxSize)
                    {
                        front = 0;
                    }
                    itemCount--;
                    return dequeuedValue;
                }
                else 
                {
                    Console.WriteLine("Queue is Empty. Cannot Dequeue Element.");
                }
                return -1;
            }
            public void PrintQueue() 
            {
                Console.WriteLine("Queue: ");
                for (int i = 0; i < itemCount; i++) 
                {
                    int index = (front + i) % maxSize;
                    Console.WriteLine($"{queueArray[index]}");
                }

            }
        }
        static void Main(string[] args)
        {
            QueueUsingArray queue = new QueueUsingArray(6);
            queue.Enqueue(11);
            queue.Enqueue(12);
            queue.Enqueue(13);
            queue.Enqueue(14);
            queue.Enqueue(15);
            queue.PrintQueue();
            int dequeuedValue = queue.Dequeue();
            Console.WriteLine($"Dequeued value: {dequeuedValue}");
        }
    }
}
