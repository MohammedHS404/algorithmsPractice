int?[] arr = new int?[]
{
    2, 1, 3
};

TreeNode root = new BinaryTreeFromArray().ArrayToTree(arr);

bool result = new Solution().IsValidBST(root);

Console.WriteLine(result);

public class Solution
{
    public bool IsValidBST(TreeNode? root)
    {
        return Helper(root, long.MinValue, long.MaxValue);
    }

    bool Helper(TreeNode? root, long left, long right)
    {
        if (root == null)
        {
            return true;
        }

        if (root.val <= left || root.val >= right)
        {
            return false;
        }

        return Helper(root.left, left, root.val) && Helper(root.right, root.val, right);
    }

}