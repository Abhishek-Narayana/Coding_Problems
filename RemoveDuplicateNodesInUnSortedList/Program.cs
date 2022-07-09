using System;
using System.Collections.Generic;

namespace RemoveDuplicateNodesInUnSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new Node(50));
            list.Insert(new Node(20));
            list.Insert(new Node(50));
            list.Insert(new Node(40));

            list.RemoveDuplicate();
        }
    }

    class Node
    {
        public Node next;
        public int data;

        public Node(int data)
        {
            this.data = data;
        }
    }

    class LinkedList
    {
        Node head;

        public LinkedList(Node head)
        {
            this.head = head;
        }

        public void Insert(Node newNode)
        {
            if (head == null)
            {
                head = newNode;
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = newNode;
        }

        public void RemoveDuplicate()
        {
            if (head == null)
            {
                return;
            }

            HashSet<int> uniqueNode = new HashSet<int>();
            Node prev = null;
            Node cur = head;
            while (cur != null)
            {
                if (uniqueNode.Add(cur.data))
                {
                    prev = cur;
                }
                else
                {
                    prev.next = cur.next;
                }
                cur = cur.next;
            }
        }
    }
}
