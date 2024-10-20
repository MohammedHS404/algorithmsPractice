using System.Text;

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

    public override string ToString()
    {
        Node<T>? current = this;
        StringBuilder sb = new StringBuilder();

        while (current != null)
        {
            sb.Append(current.Data);
            sb.Append(" -> ");
            current = current.Next;
        }
        
        // Remove the last " -> "
        
        sb.Remove(sb.Length - 4, 4);

        return sb.ToString();
    }
    
    public static Node<T> FromArray(T[] array)
    {
        Node<T> head = new Node<T>(array[0]);
        Node<T> current = head;

        for (int i = 1; i < array.Length; i++)
        {
            current.Next = new Node<T>(array[i]);
            current = current.Next;
        }

        return head;
    }
}