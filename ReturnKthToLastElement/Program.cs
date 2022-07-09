using System;

namespace ReturnKthToLastElement
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new Node(50));
            list.Insert(new Node(20));
            list.Insert(new Node(50));
            list.Insert(new Node(40));

            LinkedList result = list.ReturnKthToLastElement(2);
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

        internal LinkedList ReturnKthToLastElement(int pos)
        {
            if (head == null)
            {
                return null;
            }

            Node temp = head;
            while (pos > 0)
            {
                temp = temp.next;
                pos--;
            }

            LinkedList result = null;
            while (temp != null)
            {
                if (result == null)
                {
                    result = new LinkedList(new Node(temp.data));
                }
                else
                {
                    result.Insert(new Node(temp.data));
                }
                temp = temp.next;
            }
            return result;
        }
    }
}
