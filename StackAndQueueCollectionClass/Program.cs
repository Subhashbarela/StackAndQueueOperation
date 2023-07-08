using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueueCollectionClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.push(56);
            stack.push(30);
            stack.push(70);
            Console.WriteLine("1: Create Stack \n2: Pop And Peek");
            Console.WriteLine("Enter the choice");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("............................");
                        stack.Display();
                        break;
                    }
                case 2:
                    {
                        
                        stack.Display();
                        Console.WriteLine("\n...........................\n");
                        stack.pop();
                        // stack.peek();
                        stack.Display();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Please insert valid input");
                        break;
                    }
            }
            
            Console.Read();
        }
    }
}
