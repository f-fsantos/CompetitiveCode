using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_15___LinkedList {
    class Program {
        static void Main(string[] args) {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T--> 0) {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
        public static void display(Node head) {
            Node start = head;
            while (start != null) {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        public static Node insert(Node head, int data) {
            Node node = new Node(data);
            if (head == null)
                return node;
            Node tmpNode = head;
            while (tmpNode.next != null)
                tmpNode = tmpNode.next;
            tmpNode.next = node;
            return head;
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
