using System;

Solution solution = new();

int[] arr1 = { 1, 2, 4 };

ListNode? node1 = NodeFromArray(arr1);

int[] arr2 = { 1, 3, 4 };

ListNode? node2 = NodeFromArray(arr2);

int[] arr3 = { 2, 6 };

ListNode? node3 = NodeFromArray(arr3);

ListNode[] nodes =
    {
        node1, node2, node3
    }
    ;
ListNode n = solution.MergeKLists(nodes);

while (n != null)
{
    Console.Write(n.val);
    n = n.next;
}

ListNode? NodeFromArray(int[] ints)
{
    ListNode listNode = null;

    for (int i = ints.Length - 1; i >= 0; i--)
    {
        ListNode node = new ListNode(ints[i], listNode);
        listNode = node;
    }

    return listNode;
}

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length < 1)
        {
            return null;
        }

        while (lists.Length > 1)
        {
            List<ListNode> mergedLists = new();

            for (int i = 0; i < lists.Length; i += 2)
            {
                ListNode l1 = lists[i];
                ListNode? l2 = lists.ElementAtOrDefault(i + 1);

                ListNode mergedList = MergeTwoLists(l1, l2);
                mergedLists.Add(mergedList);
            }

            lists = mergedLists.ToArray();
        }

        return lists[0];
    }

    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        ListNode current = new();
        ListNode holder = current;

        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }

            current = current.next;
        }

        if (list1 != null)
        {
            current.next = list1;
        }
        else if (list2 != null)
        {
            current.next = list2;
        }

        return holder.next;
    }
}