using System;

namespace _2_两数相加
{

    //  Definition for singly-linked list.
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
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int current = 0;
            ListNode currentNode = new ListNode(0);
            ListNode lastNode = currentNode;
            while (l1 != null || l2 != null || current != 0)
            {
                current = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + current;
                lastNode.next = new ListNode(current % 10);
                lastNode = lastNode.next;
                current = current / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return currentNode.next;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var l1 = generateList(new int[] { 2,4,3 });
            var l2 = generateList(new int[] { 5,6,4 });
            PrintNode(l1);
            PrintNode(l2);
            var s = new Solution();
            var result = s.AddTwoNumbers(l1, l2);
            PrintNode(result);
        }
        static void PrintNode(ListNode vals)
        {
            while (vals != null)
            {
                Console.Write($"{vals.val}, ");
                vals = vals.next;
            }
            Console.WriteLine(" ");
        }
        static ListNode generateList(int[] vals)
        {
            ListNode currentNode = null;
            ListNode lastNode = null;

            foreach (var val in vals)
            {
                if (currentNode is null)
                {
                    currentNode = new ListNode(val);
                    lastNode = currentNode;
                }
                else
                {
                    lastNode.next = new ListNode(val);
                    lastNode = lastNode.next;
                }
            }

            return currentNode;
        }

    }
}
