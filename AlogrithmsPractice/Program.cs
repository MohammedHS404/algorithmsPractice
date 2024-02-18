int?[] array = { 4,2,7,1,3,6,9 };

BinaryTreeFromArray binaryTree = new BinaryTreeFromArray();

TreeNode? root = binaryTree.ArrayToTree(array);
Solution solution = new Solution();
TreeNode result = solution.InvertTree(root);
int[] resultArray = BinaryTreeToArray.ConvertToArray(result);
Console.WriteLine(string.Join(",", resultArray));

public class Solution
{
    public TreeNode? InvertTree(TreeNode? root)
    {
        if (root == null)
        {
            return null;
        }
        
        InvertTree(root.left);
        
        InvertTree(root.right);
        
        TreeNode temp = root.left;
        root.left = root.right;
        root.right = temp;
        
        return root;
    }
}