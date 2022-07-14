using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace Codelet.Tests
{
    [TestClass()]
    public class LinkedListTests
    {
        /// <summary>
        /// Test case to reverse list of H->A->B->C->D->E->null
        /// </summary>
        [TestMethod()]
        public void ReverseListTest1()
        {
            // Construct a linked list  A,B,C,D,E
            ListNode nodeE = new ListNode("E", null);
            ListNode nodeD = new ListNode("D", nodeE);
            ListNode nodeC = new ListNode("C", nodeD);
            ListNode nodeB = new ListNode("B", nodeC);
            ListNode nodeA = new ListNode("A", nodeB);

            LinkedList linkedList = new LinkedList(nodeA);

            linkedList.ReverseList();

            ListNode tempNode = linkedList.Head.Next;
            StringBuilder str = new StringBuilder();

            while (tempNode != null)
            {
                str.Append(tempNode.Data);
                tempNode = tempNode.Next;
            }

            Assert.AreEqual("EDCBA", str.ToString());
        }

        /// <summary>
        /// Test case to reverse list of H->null
        /// </summary>
        public void ReverseListTest2()
        {
            // Construct a linked list H->null
            ListNode nodeA = new ListNode(null, null);

            LinkedList linkedList = new LinkedList(nodeA);

            linkedList.ReverseList();

            ListNode tempNode = linkedList.Head.Next;
            StringBuilder str = new StringBuilder();

            while (tempNode != null)
            {
                str.Append(tempNode.Data);
                tempNode = tempNode.Next;
            }

            Assert.AreEqual(String.Empty, str.ToString());

        }

        /// <summary>
        /// Test case to reverse list of H->A->null
        /// </summary>
        public void ReverseListTest3()
        {
            // Construct a linked list H->A->null
            ListNode nodeA = new ListNode("A", null);

            LinkedList linkedList = new LinkedList(nodeA);

            linkedList.ReverseList();

            ListNode tempNode = linkedList.Head.Next;
            StringBuilder str = new StringBuilder();

            while (tempNode != null)
            {
                str.Append(tempNode.Data);
                tempNode = tempNode.Next;
            }

            Assert.AreEqual("A", str.ToString());
        }
    }
}
