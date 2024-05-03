int?[] arr = new int?[]
{
    5, 4, 8, 11, null, 13, 4, 7, 2, null, null, 5, 1
};

TreeNode root = new BinaryTreeFromArray().ArrayToTree(arr);

IList<IList<int>> result = new Solution().PathSum(root, 22);

foreach (var path in result)
{
    Console.WriteLine(string.Join(" -> ", path));
}

public class Solution
{
    public IList<IList<int>> PathSum(TreeNode root, int targetSum)
    {
        IList<IList<int>> result = new List<IList<int>>();
        List<int> currentPath = new List<int>();
        PathSum(root, targetSum, currentPath, result);
        return result;
    }

    void PathSum(TreeNode? root, int targetSum, List<int> currentPath, IList<IList<int>> result)
    {
        if (root == null)
        {
            return;
        }

        currentPath.Add(root.val);

        if (root.left == null && root.right == null && targetSum == root.val)
        {
            result.Add(new List<int>(currentPath));
            currentPath.RemoveAt(currentPath.Count - 1);
            return;
        }

        PathSum(root.left, targetSum - root.val, currentPath, result);

        PathSum(root.right, targetSum - root.val, currentPath, result);

        currentPath.RemoveAt(currentPath.Count - 1);
    }
}