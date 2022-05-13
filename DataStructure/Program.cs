using System;

namespace DataStructure
{
    public class Node
    {
        public int value;
        public Node left;
        public Node right;

        public Node(int data)
        {
            value = data;
        }
    }

    class BinaryTree
    {
        private Node _head;

        public Node Head
        {
            get
            {
                return _head;
            }
        }

        public void Add(int value)
        {
            if(_head == null)
            {
                _head = new Node(value);
                return;
            }

            Node temp = _head;
            while(temp != null)
            {
                if (value <= temp.value)
                {
                    if (temp.left == null)
                    {
                        temp.left = new Node(value);
                        return;
                    }
                    temp = temp.left;
                }
                else
                {
                    if (temp.right == null)
                    {
                        temp.right = new Node(value);
                        return;
                    }
                    temp = temp.right;
                }
            }
        }

        public static int GetHeight(Node node)
        {
            while (node != null)
            {
                int height = Math.Max(GetHeight(node.left), GetHeight(node.right)) + 1;
                return height;
            }
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.Add(50);
            binaryTree.Add(40);
            binaryTree.Add(60);
            binaryTree.Add(70);
            binaryTree.Add(75);

            Console.WriteLine(BinaryTree.GetHeight(binaryTree.Head));
            Console.ReadLine();
        }
    }
}
