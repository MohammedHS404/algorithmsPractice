int?[] array = { -10, 9, 20, null, null, 15, 7 };

BinaryTreeFromArray binaryTree = new BinaryTreeFromArray();

TreeNode? root = binaryTree.ArrayToTree(array);
Solution solution = new();
Console.WriteLine(solution.MaxPathSum(root));

public class Solution
{
    int maxSum;

    public int MaxPathSum(TreeNode? root)
    {
        maxSum = root.val;
        
        DfsSum(root);

        return maxSum;
    }

    public int DfsSum(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        int leftPath = Math.Max(DfsSum(root.left), 0);

        int rightPath = Math.Max(DfsSum(root.right), 0);

        maxSum = Math.Max(maxSum, leftPath + rightPath + root.val);

        int maxWithoutSplitting = Math.Max(leftPath, rightPath) + root.val;

        return maxWithoutSplitting;
    }
}