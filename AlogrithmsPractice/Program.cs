using AlogrithmsPractice;

Node<int> node = Node<int>.FromArray([
    1, 1, 2, 3, 4, 4, 5
]);

RemoveDuplicates(node);

Console.WriteLine(node.ToString());

void RemoveDuplicates(Node<int> head)
{
    Node<int>? r1 = head;
    Node<int>? r2 = head.Next;

    if (r2 == null)
    {
        return;
    }

    Node<int>? r2Prev = head;
    Node<int>? r1Prev = null;
    bool isR2AfterR1 = true;

    while (r1 != null)
    {
        if (r1.Data == r2.Data)
        {
            if (isR2AfterR1)
            {
                r2Prev.Next = r2.Next;
            }
            else if (r1Prev != null)
            {
                r1Prev.Next = r1.Next;
            }
        }
        else
        {
            r1Prev = r1;
            r2Prev = r2;
        }

        r1 = r1.Next;
        r2 = r2.Next?.Next;

        if (r2 == null)
        {
            r2 = head;
            isR2AfterR1 = false;
        }
    }
}