using AlogrithmsPractice;

int?[] array = { 3, 9, 20, null, null, 15, 7 };

BinaryTree binaryTree = new BinaryTree();

TreeNode? root = binaryTree.CreateBinaryTreeFromArray(array);

public class Solution
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        int left = MaxDepth(root.left);
        int right = MaxDepth(root.right);
        return 1 + Math.Max(left ,right);
    }
}