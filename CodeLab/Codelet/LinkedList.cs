﻿namespace Codelet
{
    /// <summary>
    /// List node
    /// </summary>
    public class ListNode
    {
        /// <summary>
        /// Node object
        /// </summary>
        public object Data { get; private set; }

        /// <summary>
        /// Next node in the list
        /// </summary>
        public ListNode Next { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="data">Node object</param>
        /// <param name="next">Next node in a list</param>
        public ListNode(object data, ListNode next)
        {
            Data = data;
            Next = next;
        }
    }

    /// <summary>
    /// Linked list
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// Head node of a list
        /// </summary>
        public ListNode Head { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="node">Next node</param>
        public LinkedList(ListNode node)
        {
            Head = new ListNode(null, node);
        }

        /// <summary>
        /// Reverse a linked list
        /// </summary>
        /// <param name="linkedList">a linked list</param>
        public void ReverseList()
        {
            if (this.Head.Next == null)
            {
                return;
            }

            ListNode tempNode1 = this.Head.Next;
            ListNode tempNode2 = tempNode1.Next;
            tempNode1.Next = null;

            while (tempNode2 != null)
            {
                this.Head.Next = tempNode2;
                tempNode2 = tempNode2.Next;
                this.Head.Next.Next = tempNode1;
                tempNode1 = this.Head.Next;
            }

            return;
        }
    }
}
