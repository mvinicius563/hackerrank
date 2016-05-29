using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank_cs._30DaysOfCode
{
    public class MoreLinkedLists
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int d)
            {
                data = d;
                next = null;
            }
        }
        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }

        public MoreLinkedLists()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }

        /// Task:
        public static Node removeDuplicates(Node head)
        {
            Node current = head;
            Node previous = null;
            while (current != null)
            {
                if (previous != null && current.data == previous.data) //dup
                {
                    current = current.next;
                    previous.next = current;
                    continue;
                }

                previous = current;
                current = current.next;
                
            }

            return head;
        }        
    }
}
