using System;
using System.Collections.Generic;

namespace AddTwoNumbers
{
    // https://leetcode.com/problems/add-two-numbers/submissions/
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] num1 = new int[1] { 9 };
            int[] num2 = new int[10] { 1,9,9,9,9,9,9,9,9,9 };

            #region data creation
            ListNode head = null, temp = null;
            for (int i = 0; i < num1.Length; i++)
            {
                ListNode newNode = new ListNode(num1[i] % 10);
                if (head == null)
                {
                    head = temp = newNode;
                    continue;
                }
                temp.next = newNode;
                temp = temp.next;
            }

            ListNode head2 = null;
            temp = null;
            for (int i = 0; i < num2.Length; i++)
            {
                ListNode newNode = new ListNode(num2[i] % 10);
                if (head2 == null)
                {
                    head2 = temp = newNode;
                    continue;
                }
                temp.next = newNode;
                temp = temp.next;
            }
            #endregion

            AddTwoNumbers(head, head2);
            Console.ReadLine();
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            ListNode head = null, cur = null;
            while (l1 != null || l2!= null || carry == 1)
            {
                int sum = GetNumber(ref l1) + GetNumber(ref l2) + carry;
                carry = sum / 10;
                if (head == null)
                    cur = head = new ListNode(sum % 10);
                else
                    cur = cur.next = new ListNode(sum % 10); ;
            }
            return head;
        }

        private static int GetNumber(ref ListNode node )
        {
            int num = 0;
            if (node != null)
            {
                num = node.val;
                node = node.next;
            }
            return num;
        }
    }
}
