
int?[] arr = new int?[]
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
        
        int diameter = Height(root.left) + Height(root.right);
        
        int leftDiameter = DiameterOfBinaryTree(root.left);
        
        int rightDiameter = DiameterOfBinaryTree(root.right);
        
        return Math.Max(diameter, Math.Max(leftDiameter, rightDiameter));
    }
    
    int Height(TreeNode? node)
    {
        if (node == null)
        {
            return 0;
        }
        
        return 1 + Math.Max(Height(node.left), Height(node.right));
    }
}