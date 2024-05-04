namespace AlogrithmsPractice;

public class SinglyLinkedListNode
{
    public int data { get; set; }
    public SinglyLinkedListNode? next { get; set; }

    public SinglyLinkedListNode(int data)
    {
        this.data = data;
        this.next = null;
    }

    public SinglyLinkedListNode(int data, SinglyLinkedListNode next)
    {
        this.data = data;
        this.next = next;
    }
}


public class SinglyLinkedListNodeHandler
{
    
    public static SinglyLinkedListNode? FromArray(int[] arr)
    {
        SinglyLinkedListNode? head = null;
        SinglyLinkedListNode? current = null;

        foreach (var item in arr)
        {
            if (head == null)
            {
                head = new SinglyLinkedListNode(item);
                current = head;
            }
            else
            {
                current!.next = new SinglyLinkedListNode(item);
                current = current.next;
            }
        }

        return head!;
    }
    
    public static int[] ToArray(SinglyLinkedListNode? head)
    {
        List<int> list = new();
        SinglyLinkedListNode? current = head;

        while (current != null)
        {
            list.Add(current.data);
            current = current.next;
        }

        return list.ToArray();
    }
}