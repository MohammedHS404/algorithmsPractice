Solution solution = new();

int?[] arr =
{
    3, 9, 20, null, null, 15, 7
};

TreeNode root = new BinaryTreeFromArray().ArrayToTree(arr);

IList<IList<int>> res = solution.LevelOrder(root);

foreach (IList<int> list in res)
{
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}


public class Solution
{
    public IList<IList<int>> LevelOrder(TreeNode root)
    {
        List<TreeNode?> queue = new();

        queue.Add(root);

        List<IList<int>> result = new();

        while (queue.Count > 0)
        {
            int size = queue.Count;

            List<int> level = new();

            for (int i = 0; i < size; i++)
            {
                TreeNode? node = queue[0];

                queue.RemoveAt(0);
                
                if (node == null)
                {
                    continue;
                }
                
                level.Add(node.val);

                if (node.left != null)
                {
                    queue.Add(node.left);
                }

                if (node.right != null)
                {
                    queue.Add(node.right);
                }
            }

            if (level.Count > 0)
            {
                result.Add(level);
            }
        }

        return result;
    }
}