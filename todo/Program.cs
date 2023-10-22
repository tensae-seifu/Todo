using System;
using System.Collections.Generic;

namespace todo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                Console.WriteLine("Choose what you wish to do");
                Console.WriteLine("+ to ADD");
                Console.WriteLine("L to list");
                Console.WriteLine("N to See Next item");
                char val = Convert.ToChar(Console.ReadLine());

                switch (val)
                {
                    case '+':
                        AddList();
                        break;
                    case 'L':
                        GetList();
                        break;
                    case 'N':
                        NextItem();
                        break;
                    default:
                        Console.WriteLine("Wrong choice");
                        break;
                }
            }

            void GetList()
            {
                foreach (string item in queue)
                {
                    Console.WriteLine(item);
                }
            }

            void AddList()
            {
                string answer;

                do
                {
                    Console.WriteLine("Lägg till to do");
                    string todo = Console.ReadLine();
                    queue.Enqueue(todo);
                    Console.WriteLine("Would you like to add more? (y/n): ");
                    answer = Console.ReadLine();

                    if (answer.ToLower() != "y")
                    {
                        break; 
                    }
                } while (true);
            }

            void NextItem()
            {
                if (queue.Count > 0)
                {
                    Console.WriteLine(queue.Peek());
                }
                else
                {
                    Console.WriteLine("Queue is empty");
                }
            }
        }
    }
}
