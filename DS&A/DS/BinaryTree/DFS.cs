using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.DS.BinaryTree
{
    internal class DFS
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

            // ROOT -> LEFT -> RIGHT
            public void PreOrder(Node node)
            {
                if (Root == null) return;
                Console.Write(node.Value + " ");

                PreOrder(node.Left);
                PreOrder(node.Right);


            }

            public void IterativePreorderDFS()
            {
                if (Root == null) return;

                Stack<Node> stack = new Stack<Node>();
                stack.Push(Root);

                while (stack.Count > 0)
                {
                    Node current = stack.Pop();
                    Console.Write(current.Value + " ");

                    
                    if (current.Right != null)
                        stack.Push(current.Right);

                    if (current.Left != null)
                        stack.Push(current.Left);
                }
            }

            // LEFT -> RIGHT -> ROOT
            public void PostOrder(Node node)
            {
                if (Root == null) return;
                PostOrder(node.Left);            
                PostOrder(node.Right);
                Console.Write(node.Value + " ");


            }

            //public IList<int> PostorderTraversal(TreeNode root)
            //{
            //    List<int> list = new List<int>();
            //    PostorderHelper(root, list);

            //    return list;
            //}

            //private void PostorderHelper(TreeNode node, List<int> list)
            //{
            //    if (node == null) return;
            //    PostorderHelper(node.left, list);
            //    PostorderHelper(node.right, list);
            //    list.Add(node.val);
            //}
            public void IterativePostorderDFS()
            {
                if (Root == null) return;

                Stack<Node> stack1 = new Stack<Node>();
                Stack<Node> stack2 = new Stack<Node>();

                stack1.Push(Root);

                while (stack1.Count > 0)
                {
                    Node current = stack1.Pop();
                    stack2.Push(current);

                    
                    if (current.Left != null)
                        stack1.Push(current.Left);

                    if (current.Right != null)
                        stack1.Push(current.Right);
                }

                
                while (stack2.Count > 0)
                {
                    Console.Write(stack2.Pop().Value + " ");
                }
            }
            // LEFT -> ROOT -> RIGHT
            public void InOrder(Node node)
            {
                if (Root == null) return;
                InOrder(node.Left);               
                Console.Write(node.Value + " ");  
                InOrder(node.Right);

            }
            //public IList<int> InorderTraversal(TreeNode root)
            //{
            //    List<int> list = new List<int>();
            //    InorderHelper(root, list);
            //    return list;
            //}

            //private void InorderHelper(TreeNode node, List<int> list)
            //{
            //    if (node == null) return;
            //    InorderHelper(node.left, list);
            //    list.Add(node.val);
            //    InorderHelper(node.right, list);
            //}

            public void IterativeInorderDFS()
            {
                Stack<Node> stack = new Stack<Node>();
                Node current = Root;

                while (current != null || stack.Count > 0)
                {
                    
                    while (current != null)
                    {
                        stack.Push(current);
                        current = current.Left;
                    }

                    
                    current = stack.Pop();
                    Console.Write(current.Value + " ");

                    
                    current = current.Right;
                }
            }
        }
    }
}
