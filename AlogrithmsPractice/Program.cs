using AlogrithmsPractice;

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{
    public TreeNode SortedListToBST(ListNode start)
    {
        if (start == null)
            return null;

        if (start.next == null)
            return new TreeNode(start.val);

        ListNode middle = start;
        ListNode last = start;
        ListNode prev = null;

        while (last != null && last.next != null)
        {
            prev = middle;
            middle = middle.next;
            last = last.next.next;
        }

        prev.next = null;

        TreeNode root = new(middle.val);
        root.left = SortedListToBST(start);
        root.right = SortedListToBST(middle.next);

        return root;
    }
}