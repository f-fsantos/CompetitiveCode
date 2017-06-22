using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_22___Binary_Search_Trees {
    class Program {
        static void Main(string[] args) {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0) {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }
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
        static int getHeight(Node root) {
            int a = 0, b = 1, tempb = 1, level = -1;
            List<Node> visitedNodes = new List<Node> {
                root
            };
            while (a < b) {
                for(int i = a; i < b; i++) {
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
                level++;
            }

            return level;
        }
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
