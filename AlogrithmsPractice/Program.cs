BinaryTreeFromArray binaryTree = new BinaryTreeFromArray();

TreeNode? root = binaryTree.ArrayToTree(new int?[] { 1, 3 });
TreeNode? root2 = binaryTree.ArrayToTree(new int?[] { 1, 2, 3 });

Solution solution = new();
Console.WriteLine(solution.IsSameTree(root, root2));

public class Solution
{
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p == null && q == null)
        {
            return true;
        }

        if (p?.val != q?.val)
        {
            return false;
        }

        return IsSameTree(p?.left, q?.left) && IsSameTree(p?.right, q?.right);
    }
}