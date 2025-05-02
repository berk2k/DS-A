using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.DS.BinaryTree
{
    internal class BFS
    {
        class Node
        {
            public int Value;
            public Node Left;
            public Node Right;

            public Node(int value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree
        {
            public Node Root;

            public void BreadthFirstTraversal()
            {
                if (Root == null) return;

                Queue<Node> queue = new Queue<Node>();
                queue.Enqueue(Root);

                while (queue.Count > 0)
                {
                    Node current = queue.Dequeue();
                    Console.Write(current.Value + " ");

                    if (current.Left != null)
                        queue.Enqueue(current.Left);

                    if (current.Right != null)
                        queue.Enqueue(current.Right);
                }
            }
        }
    }
}
