using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class TreeNode
    {
        public int val;
        public TreeNode left, right;

        public TreeNode(int val)
        {
            this.val = val;
        }

        public void Insert(int newVal)
        {
            if (newVal <= val)
            {
                if (left == null) left = new TreeNode(newVal);
                else left.Insert(newVal);
            }
            else
            {
                if (right == null) right = new TreeNode(newVal);
                else right.Insert(newVal);
            }
        }

        public void InOrder(List<int> result)
        {
            if (left != null) left.InOrder(result);
            result.Add(val);
            if (right != null) right.InOrder(result);
        }
    }

    public class TreeSort
    {
        public static List<int> Sort(int[] array)
        {
            if (array.Length == 0) return new List<int>();

            TreeNode root = new TreeNode(array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                root.Insert(array[i]);
            }

            List<int> sorted = new List<int>();
            root.InOrder(sorted);
            return sorted;
        }
    }


