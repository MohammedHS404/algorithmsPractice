public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTreeFromArray
{
    public TreeNode ArrayToTree(int?[]? arr)
    {
        if (arr == null || arr.Length == 0)
            return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();


        TreeNode root = arr[0] == null ? null : new TreeNode(arr[0].Value);
        queue.Enqueue(root);
        int i = 1;

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (i < arr.Length && arr[i] != null)
            {
                current.left = new TreeNode(arr[i].Value);
                queue.Enqueue(current.left);
            }

            i++;

            if (i < arr.Length && arr[i] != null)
            {
                current.right = new TreeNode(arr[i].Value);
                queue.Enqueue(current.right);
            }

            i++;
        }

        return root;
    }
}