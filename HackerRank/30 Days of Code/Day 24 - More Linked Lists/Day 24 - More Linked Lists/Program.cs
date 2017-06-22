using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_24___More_Linked_Lists {
    class Program {
        static void Main(string[] args) {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
        public static Node removeDuplicates(Node head) {
            Node node = head, tempNode = head;
            List<int> visitedData = new List<int>();

            while (node != null) {
                if (!visitedData.Contains(node.data)) {
                    visitedData.Add(node.data);
                    tempNode = node;
                }
                else {
                    if (node.next != null)
                        tempNode.next = node.next;
                    else
                        tempNode.next = null;
                }
                node = node.next;
            }
            return head;
        }
        public static Node insert(Node head, int data) {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head) {
            Node start = head;
            while (start != null) {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
    class Node {
        public int data;
        public Node next;
        public Node(int d) {
            data = d;
            next = null;
        }

    }
}
