using AlogrithmsPractice;

Node<int> node = new Node<int>(1);
node.Append(2);
node.Append(3);
node.Append(4);

node.Delete(3);

for (Node<int>? current = node; current != null; current = current.Next)
{
    Console.Write(current.Data + " ");
}

Console.WriteLine();