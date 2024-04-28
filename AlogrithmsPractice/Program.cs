Solution solution = new Solution();

int?[] array = new int?[]
{
    1, 2, 2, null, 3, null, 3
};

TreeNode root = new BinaryTreeFromArray().ArrayToTree(array);

bool result = solution.IsSymmetric(root);

Console.WriteLine(result);


public class Solution
{
    public bool IsSymmetric(TreeNode? root)
    {
        if (root == null)
        {
            return true;
        }

        if (root.left == null && root.right == null)
        {
            return true;
        }

        return IsSymmetricDfs(root.left, root.right);
    }

    static bool IsSymmetricDfs(TreeNode? left, TreeNode? right)
    {
        if (left == null && right == null)
        {
            return true;
        }

        if (left?.val != right?.val)
        {
            return false;
        }

        return IsSymmetricDfs(left.left, right.right) && IsSymmetricDfs(left.right, right.left);
    }
}