using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_23___BST_Level_order_Traversal {
    class Program {
        static Node insert(Node root, int data) {
            if (root == null) {
                return new Node(data);
            }
            else {
                Node cur;
                if (data <= root.data) {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void levelOrder(Node root) {
            List<Node> visitedNodes = new List<Node> { root };
            string nodeOrder = "";
            int a = 0, b = 1, tempb = b;
            while(a < b) {
                for(int i = a; i < b; i++) {
                    nodeOrder += visitedNodes[i].data + " ";
                    if (visitedNodes[i].left != null) {
                        visitedNodes.Add(visitedNodes[i].left);
                        tempb++;
                    }
                    if (visitedNodes[i].right != null) {
                        visitedNodes.Add(visitedNodes[i].right);
                        tempb++;
                    }
                }
                a = b;
                b = tempb;
            }
            Console.WriteLine(nodeOrder.Trim());
        }
        static void Main(String[] args) {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
        class Node {
            public Node left, right;
            public int data;
            public Node(int data) {
                this.data = data;
                left = right = null;
            }
        }
    }
}
