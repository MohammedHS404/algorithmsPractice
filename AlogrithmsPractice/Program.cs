int?[] arr = new int?[]
{
    2,1,3
};

TreeNode root = new BinaryTreeFromArray().ArrayToTree(arr);

bool result = new Solution().IsValidBST(root);

Console.WriteLine(result);

public class Solution
{
    public bool IsValidBST(TreeNode? root)
    {
        return Helper(root).Item1;
    }

    (bool, long, long) Helper(TreeNode? root)
    {
        if (root == null)
        {
            return (true, long.MinValue, long.MaxValue);
        }
        
        (bool leftValid, long leftMax, long leftMin) = Helper(root.left);

        if (!leftValid || leftMax >= root.val)
        {
            return (false, 0, 0);
        }

        (bool rightValid, long rightMax, long rightMin) = Helper(root.right);

        if (!rightValid || rightMin <= root.val)
        {
            return (false, 0, 0);
        }

        return (true, Math.Max(rightMax, root.val), Math.Min(leftMin, root.val));
    }

}