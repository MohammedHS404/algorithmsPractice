public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class BinaryTreeFromArray
{
    public TreeNode? ArrayToTree(int[] arr)
    {
        if (arr == null || arr.Length == 0)
            return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();


        TreeNode? root = new TreeNode(arr[0]);
        queue.Enqueue(root);
        int i = 1;

        while (queue.Count > 0)
        {
            TreeNode current = queue.Dequeue();

            if (i < arr.Length)
            {
                current.left = new TreeNode(arr[i]);
                queue.Enqueue(current.left);
            }

            i++;

            if (i < arr.Length)
            {
                current.right = new TreeNode(arr[i]);
                queue.Enqueue(current.right);
            }

            i++;
        }

        return root;
    }
}

public class BinaryTreeToArray
{
    public static int[] ConvertToArray(TreeNode root)
    {
        if (root == null)
            return new int[0];

        List<int> list = new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            list.Add(node.val);
            if (node.left != null)
                queue.Enqueue(node.left);
            if (node.right != null)
                queue.Enqueue(node.right);
        }

        return list.ToArray();
    }
}