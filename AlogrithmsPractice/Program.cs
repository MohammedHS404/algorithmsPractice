
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

        Stack<(TreeNode,int)> nextNodes = new Stack<(TreeNode,int)>();

        nextNodes.Push((root,1));

        int maxDepth = 0;
        

        while (nextNodes.Count > 0)
        {
            (TreeNode currentNode,int depth)  = nextNodes.Pop();
            
            Console.WriteLine(currentNode.val);

            if (currentNode.right != null)
            {
                nextNodes.Push((currentNode.right,depth+1));
            }

            if (currentNode.left != null)
            {
                nextNodes.Push((currentNode.left,depth+1));
            }

            if (currentNode.left == null && currentNode.right == null)
            {
                maxDepth = Math.Max(depth, maxDepth);
            }
        }

        return maxDepth;
    }
}