using System;
using System.Collections.Generic;
using System.Text;

namespace StackApplication
{
    class LinkedListStack
    {
        public Node top;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedListStack"/> class.
        /// </summary>
        public LinkedListStack()
        {
            this.top = null;
        }

        /// <summary>
        /// Pushes the specified new data.
        /// </summary>
        /// <param name="newData">The new data.</param>
        public void Push(int newData)
        {
            Node newNode = new Node(newData);
            if (top == null)
            {
                newNode.next = null;
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
            Console.WriteLine("{0} pushed into stack",newData);
        }
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.Write(temp.data + "  ");
                temp = temp.next;
            }
        }


    }
}
