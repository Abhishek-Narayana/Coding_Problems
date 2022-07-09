using System;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new Node(50));
            list.InsertLast(new Node(60));
            list.InsertLast(new Node(70));
            list.InsertLast(new Node(80));
            // list.DeleteFirst();
            // list.DeleteLast();
            list.DeleteAt(0);

            list.Display();
            Console.ReadLine();
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

        public void InsertFirst(Node newNode)
        {
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }

        public void InsertLast(Node newNode)
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

        public void InsertAt(Node newNode, int index)
        {
            if (index == 0)
            {
                InsertFirst(newNode);
                return;
            }

            Node temp = head;
            while (index > 0 && temp != null)
            {
                temp = temp.next;
                index--;
            }

            if (index == 0)
            {
                if (temp == null)
                {
                    InsertLast(newNode);
                    return;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
            else
            {
                Console.WriteLine("Insertion failed, Invalid position");
            }
        }

        public void DeleteFirst()
        {
            if (head == null)
            {
                return;
            }
            head = head.next;
        }

        public void DeleteLast()
        {
            if (head == null)
            {
                return;
            }

            if (head.next == null)
            {
                head = head.next;
                return;
            }

            Node prev = null;
            Node cur = head;
            while (cur.next != null)
            {
                prev = cur;
                cur = cur.next;
            }
            prev.next = null;
        }

        public void DeleteAt(int index)
        {
            if (index == 0)
            {
                DeleteFirst();
                return;
            }

            Node prev = null;
            Node cur = head;
            while (index > 0 && cur.next != null)
            {
                prev = cur;
                cur = cur.next;
                index--;
            }

            if (index == 0)
            {
                if(cur.next == null)
                {
                    prev.next = null;
                    return;
                }
                prev.next = cur.next;
            }
            else
            {
                Console.WriteLine("Deletion failed, Invalid position");
            }
        }

        public void Display()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
