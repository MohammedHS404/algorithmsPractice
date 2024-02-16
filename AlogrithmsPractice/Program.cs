
int?[] array = {3,4,5,-7,-6,null,null,-7,null,-5,null,null,null,-4};

BinaryTreeFromArray binaryTree = new BinaryTreeFromArray();

TreeNode? root = binaryTree.ArrayToTree(array);

Solution solution = new();

int max=solution.MaxDepth(root);
Console.WriteLine();
Console.WriteLine($"Depth:{max}");

public class Solution
{
    public int MaxDepth(TreeNode? root)
    {
        if (root == null)
        {
            return 0;
        }

        List<TreeNode> nodes = new();

        nodes.Add(root);
        
        int maxDepth = 0;
        
        while (nodes.Count > 0)
        {
            List<TreeNode> newNodes = new();
            
            foreach (TreeNode node in nodes)
            {
                if (node.left != null)
                {
                    newNodes.Add(node.left);
                }

                if (node.right != null)
                {
                    newNodes.Add(node.right);
                }
            }

            nodes = newNodes;

            maxDepth++;
        }

        return maxDepth;
    }
}