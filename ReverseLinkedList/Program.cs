using System;
using System.Collections.Generic;

namespace SingleLinkedList
{
    class SingleLinkedList
    {
        public Node head;
        public SingleLinkedList()
        {
            head = null;
        }

        public void Insert(int data)
        {
            if (head == null)
            {
                head = new Node(data);
                return;
            }

            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            temp.next = new Node(data);
        }

        public void Reverse()
        {
            if (head == null)
                return;

            Node prev = null, cur = head, next = null;
            while (cur != null)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
            }
            head = prev;
        }

        public static Node ReverseGroup(Node head, int groupCount)
        {
            if (head == null)
                return null;

            Node prev = null, cur = head, next = null;
            int count = 0;
            while (cur != null && count < groupCount)
            {
                next = cur.next;
                cur.next = prev;
                prev = cur;
                cur = next;
                count++;
            }

            if (next != null)
                head.next = ReverseGroup(next, groupCount);

            return prev;
        }

        public void Display()
        {
            if (head == null)
                return;

            Node temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }
        }

        public static void Display(Node head)
        {
            if (head == null)
                return;

            Node temp = head;
            while (temp != null)
            {
                Console.Write($"{temp.data} ");
                temp = temp.next;
            }
        }
    }

    public class Node
    {
        public int data;
        public Node next;

        public Node(int data)
        {
            this.data = data;
            next = null;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            Console.WriteLine("Enter linked list data");
            string listData = Console.ReadLine();
            foreach (string item in listData.Split(' '))
            {
                list.Insert(int.Parse(item));
            }

            list.Display();
            Console.WriteLine("\n");

            //LinkedList

            //// Input 1, 2, 3, 4, 5, 6, 7, 8
            //// Output 3, 2, 1, 6, 5, 4, 8, 7
            //var listNew = SingleLinkedList.ReverseGroup(list.head, 3);
            //SingleLinkedList.Display(listNew);

            Console.ReadLine();
        }
    }
}
