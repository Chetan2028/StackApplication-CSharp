﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StackApplication
{
    public class Node
    {
        public int data;
        public Node next;

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
}
