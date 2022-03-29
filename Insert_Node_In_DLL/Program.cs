using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace Insert_Node_In_DLL
{
    class Solution
    {
        class DoublyLinkedListNode
        {
            public int data;
            public DoublyLinkedListNode next;
            public DoublyLinkedListNode prev;

            public DoublyLinkedListNode(int nodeData)
            {
                this.data = nodeData;
                this.next = null;
                this.prev = null;
            }
        }

        class DoublyLinkedList
        {
            public DoublyLinkedListNode head;
            public DoublyLinkedListNode tail;

            public DoublyLinkedList()
            {
                this.head = null;
                this.tail = null;
            }

            public void InsertNode(int nodeData)
            {
                DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

                if (this.head == null)
                {
                    this.head = node;
                }
                else
                {
                    this.tail.next = node;
                    node.prev = this.tail;
                }

                this.tail = node;
            }
        }

        static void PrintDoublyLinkedList(DoublyLinkedListNode node, string sep)
        {
            while (node != null)
            {
                Console.WriteLine(node.data);

                node = node.next;

                if (node != null)
                {
                    Console.WriteLine(sep);
                }
            }
        }

        class Result
        {

            /*
             * Complete the 'sortedInsert' function below.
             *
             * The function is expected to return an INTEGER_DOUBLY_LINKED_LIST.
             * The function accepts following parameters:
             *  1. INTEGER_DOUBLY_LINKED_LIST llist
             *  2. INTEGER data
             */

            /*
             * For your reference:
             *
             * DoublyLinkedListNode
             * {
             *     int data;
             *     DoublyLinkedListNode next;
             *     DoublyLinkedListNode prev;
             * }
             *
             */

            public static DoublyLinkedListNode sortedInsert(DoublyLinkedListNode llist, int data)
            {
                if (llist == null || llist.next == null)
                    return llist;

                DoublyLinkedListNode temp = llist;
                while (data > temp.data)
                {
                    temp = temp.next;
                }

                DoublyLinkedListNode newNode = new DoublyLinkedListNode(data);
                newNode.next = temp;
                temp.prev = newNode;
                newNode.prev = temp.prev;
                temp.prev = newNode;
                

                return llist;
            }

        }

        static void Main(string[] args)
        {

            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                DoublyLinkedList llist = new DoublyLinkedList();

                int llistCount = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < llistCount; i++)
                {
                    int llistItem = Convert.ToInt32(Console.ReadLine());
                    llist.InsertNode(llistItem);
                }

                int data = Convert.ToInt32(Console.ReadLine());

                DoublyLinkedListNode llist1 = Result.sortedInsert(llist.head, data);
                PrintDoublyLinkedList(llist1, " ");
            }

            Console.ReadLine();
        }
    }
}