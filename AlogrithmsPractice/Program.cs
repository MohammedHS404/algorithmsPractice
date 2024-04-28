int?[] arr =
{
    1, 2
};

BinaryTreeFromArray bta = new BinaryTreeFromArray();

TreeNode root = bta.ArrayToTree(arr);

Solution s = new Solution();

Console.WriteLine(s.DiameterOfBinaryTree(root));

public class Solution
{
    public int DiameterOfBinaryTree(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }


        int res = 0;

        int Height(TreeNode? node)
        {
            if (node == null)
            {
                return 0;
            }

            int left = Height(node.left);
            int right = Height(node.right);
            res = Math.Max(res, left + right);

            return 1 + Math.Max(left, right);
        }

        Height(root);

        return res;
    }
}