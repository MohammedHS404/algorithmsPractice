Solution solution = new();

int[] arr = { 1, 2 };

int pos = 0;

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
        ListNode? current = head;

        HashSet<ListNode?> visited = new();

        while (current != null && !visited.Contains(current))
        {
            visited.Add(current);
            current = current.next;
        }

        if (visited.Contains(current))
        {
            return true;
        }

        return false;
    }
}