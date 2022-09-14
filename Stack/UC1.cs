using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class UC1
    {
        Node top;
        public void push(int data)
        {
            Node newnode = new Node(data);
            if (top == null)
            {
                Console.WriteLine("stack is empty");
            }
            else 
            {
                newnode.next = top;     
            }
            top = newnode;
        }
    public void Display()
    {
        if (top == null) 
            Console.WriteLine("Stack is Empty");
        while (top != null)
        {
            Console.WriteLine("|" + top.data + "|");
            top = top.next;
        }
      
    }
    }
}
