namespace DoubleLinkedList
{
    using System;
    public class Program
    {
        private static Node Root = null;
        public static void Main()
        {
            var random = new Random();
            var limit = 100;
            for (var i = 0; i < limit; i++)
            {
                Root = insertInSortedPosition(Root, random.Next(0, 1000));
            }
            ValidateList(limit);
        }
        private static Node insertInSortedPosition(Node root, int value)
        {
            var newNode = new Node
            {
                Next = null,
                Previous = null,
                Value = value
            };

            Node curNode = root;
            
            if(root == null)
            {
                return newNode;
            }
            if (value < root.Value)
            {
                BeforeNode(root, newNode);
                return newNode;
            }

            while (curNode.Next != null)
            {
                if (value < curNode.Value)
                {
                    BeforeNode(curNode, newNode);
                    return root;
                }
                curNode = curNode.Next;   
            }
            if (curNode.Value < newNode.Value)
            {
                curNode.Next = newNode;
                newNode.Previous = curNode;
            }
            else 
            {
                newNode.Next = curNode;
                newNode.Previous = curNode.Previous;
                curNode.Previous.Next = newNode;
                curNode.Previous = newNode;
            }

            return root;
        }

        private static void BeforeNode(Node oldNode, Node newNode)
        {
            if (oldNode.Previous != null)
            {
                oldNode.Previous.Next = newNode;
                newNode.Previous = oldNode.Previous;
            }
            oldNode.Previous = newNode;
            newNode.Next = oldNode;
        }

        private static void ValidateList(int exceptedNumElments)
        {
            var node = Root;
            var valid = true;
            var numElements = 0;
            while (node != null)
            {
                numElements++;
                if (numElements == 1 && (node.Previous != null || node.Next == null))
                {
                    valid = false;
                    break;
                }
                if (numElements == exceptedNumElments && (node.Next != null || node.Previous == null))
                {
                    valid = false;
                    break;
                }
                if ((node.Next != null && node.Next.Value < node.Value) || (node.Previous != null && node.Previous.Value > node.Value))
                {
                    valid = false;
                    break;
                }
                node = node.Next;
            }
            if (valid && numElements == exceptedNumElments)
            {
                Console.WriteLine("VALID");
            }
            else
            {
                Console.WriteLine("INVALID");
            }
        }
        class Node
        {
            public Node Previous { get; set; }
            public Node Next { get; set; }
            public int Value { get; set; }
        }
    }
}