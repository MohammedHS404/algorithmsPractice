Solution solution = new();

int[] arr = {  };

int pos = -1;

ListNode prev = null;

List<ListNode> nodes = new();

for (int i = arr.Length - 1; i >= 0; i--)
{
    ListNode node = new ListNode(arr[i], prev);
    nodes.Add(node);
    prev = node;
}

nodes.Reverse();

if (pos > -1)
{
    nodes.Last().next = nodes[pos];
}


bool result = solution.HasCycle(prev);

Console.WriteLine(result);

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int x)
    {
        val = x;
    }

    public ListNode(int x, ListNode next)
    {
        val = x;
        this.next = next;
    }
}

public class Solution
{
    public bool HasCycle(ListNode head)
    {
        if (head == null)
        {
            return false;
        }
        
        ListNode slow = head;
        
        ListNode? fast = head;
        
        while (true)
        {
            slow = slow.next;
            fast = fast.next?.next;
            
            if (fast == null)
            {
                return false;
            }

            if (fast.next == null)
            {
                return false;
            }

            if (fast == slow)
            {
                return true;
            }
        }
    }
}