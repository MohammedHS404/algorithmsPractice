namespace AlogrithmsPractice;

public class Node<T>
{
    public Node<T>? Next = null;
    public readonly T Data;

    public Node(T data)
    {
        Data = data;
    }

    public void Append(T data)
    {
        Node<T> end = new Node<T>(data);
        Node<T>? next = this;

        while (next.Next != null)
        {
            next = next.Next;
        }

        next.Next = end;
    }

    public void Delete(T data)
    {
        Node<T> current = this;

        while (current.Next != null)
        {
            if (current.Next.Data != null && current.Next.Data.Equals(data))
            {
                current.Next = current.Next.Next;
                return;
            }

            current = current.Next;
        }
    }
}