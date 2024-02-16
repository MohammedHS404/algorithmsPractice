namespace AlogrithmsPractice;

using System;
using System.Collections.Generic;

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;
    public TreeNode(int val = 0)
    {
        this.val = val;
    }
    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTree
{
    public TreeNode? CreateBinaryTreeFromArray(int?[] array)
    {
        return CreateBinaryTreeFromArrayHelper(array, 0);
    }

    private TreeNode? CreateBinaryTreeFromArrayHelper(int?[] array, int index)
    {
        TreeNode? root = null;

        if (index < array.Length && array[index] != null)
        {
            root = new TreeNode((int)array[index]);
            root.left = CreateBinaryTreeFromArrayHelper(array, 2 * index + 1);
            root.right = CreateBinaryTreeFromArrayHelper(array, 2 * index + 2);
        }

        return root;
    }
    
    
    public static void InOrderTraversal(TreeNode? root)
    {
        if (root != null)
        {
            InOrderTraversal(root.left);
            Console.Write(root.val + " ");
            InOrderTraversal(root.right);
        }
    }
}
