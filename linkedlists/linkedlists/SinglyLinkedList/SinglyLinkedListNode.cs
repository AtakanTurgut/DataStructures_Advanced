﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlists.SinglyLinkedList
{
    public class SinglyLinkedListNode<T>
    {
        public SinglyLinkedListNode<T> Next { get; set; }
        public T Value { get; set; }

        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }

        public override string ToString() => $"{Value}";
    }
}
