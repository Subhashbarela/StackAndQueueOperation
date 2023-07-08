using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueueCollectionClass
{
    public class Stack
    {
        private Node top;
        public Stack()
        {
            this.top = null;
        }

        public void push(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            //Console.WriteLine("{0} pushed to stack ", value);
        }
        internal void peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty ");
                return;
            }
            else
            {
                Console.WriteLine("{0}  is in the top of the stack ", this.top.data);
            }
        }
        internal void pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty Deletion is not posible ");
            }
            else
            {
                Console.Write("Value {0} is popped...! \n\n", this.top.data);
                this.top = this.top.next;
            }
        }
        internal void IsEmpty()
        {
            if (this.top != null)
            {
                while (this.top != null)
                {
                    peek();
                    pop();
                }
            }
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
