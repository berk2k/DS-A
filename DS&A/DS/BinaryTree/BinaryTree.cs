using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_A.DS.BinaryTree
{
    public class BinaryTree
    {
        public TreeNode Root;

        public BinaryTree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            Root = InsertRecursiveBST(Root, value);
        }

        private TreeNode InsertRecursiveBST(TreeNode node, int value)
        {
            if (node == null) { return new TreeNode(value)};

            if (value < node.Value)
            {
               node.Left = InsertRecursiveBST(node.Left, value);
            }

            else
            {
               node.Right = InsertRecursiveBST(node.Right, value);
            }

            return node;
        }
        public int CountNodes()
        {
            return CountNodesRecursive(Root);
        }


        private int CountNodesRecursive(TreeNode node)
        {
            if (node == null)
                return 0;

            return 1 + CountNodesRecursive(node.Left) + CountNodesRecursive(node.Right);
        }

        private TreeNode DeleteRecursive(TreeNode root, int key)
        {
            if (root == null)
                return null;

            if(key < root.Value)
            {
                root.Left = DeleteRecursive(root.Left, key);
            }
            else if(key > root.Value)
            {
                root.Right = DeleteRecursive(root.Right, key);
            }
            else
            {
                
                if (root.Left == null && root.Right == null)
                    return null;

                
                if (root.Left == null)
                    return root.Right;
                else if (root.Right == null)
                    return root.Left;
                
                else
                {
                    TreeNode minNode = FindMin(root.Right);
                    root.Value = minNode.Value;
                    root.Right = DeleteRecursive(root.Right, minNode.Value);
                }

            }
            return root;
        }

        private TreeNode FindMin(TreeNode node)
        {
            while (node.Left != null)
                node = node.Left;
            return node;
        }
    }



    public class TreeNode
    {
        public int Value;
        public TreeNode Left;
        public TreeNode Right;

        public TreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

}
