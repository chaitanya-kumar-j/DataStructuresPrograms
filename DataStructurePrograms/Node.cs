﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresPractice
{
    public class Node<T>
    {
        public T data;
        public Node<T> nextNode;
        public Node(T data)
        {
            this.data = data;
        }
    }
}
