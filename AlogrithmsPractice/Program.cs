using AlogrithmsPractice;

Node<int> node = Node<int>.FromArray([
    1,1,2,3,4,4,5
]);

RemoveDuplicates(node);

Console.WriteLine(node.ToString());

void RemoveDuplicates(Node<int> head)
{
    Node<int>? current = head;
    Node<int>? prev = null;
    HashSet<int> seen = new HashSet<int>();


    while (current != null)
    {
        if (prev != null && seen.Contains(current.Data))
        {
            prev.Next = current.Next;
        }
        else
        {
            prev = current;
        }

        seen.Add(current.Data);
        current = current.Next;
    }
}