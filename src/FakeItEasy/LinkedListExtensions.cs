﻿namespace FakeItEasy
{
    using System.Collections.Generic;

    internal static class LinkedListExtensions
    {
        public static IEnumerable<LinkedListNode<T>> Nodes<T>(this LinkedList<T> linkedList)
        {
            var node = linkedList.First;
            while (node is object)
            {
                yield return node;
                node = node.Next;
            }
        }
    }
}
