using System.Collections.Generic;

MinStack minStack = new MinStack();
minStack.Push(2147483646);
minStack.Push(2147483646);
minStack.Push(2147483647);
Console.WriteLine("Top: " + minStack.Top()); // Output: 2147483647
minStack.Pop();
Console.WriteLine("Min after pop: " + minStack.GetMin()); // Output: 2147483646
minStack.Pop();
Console.WriteLine("Min after pop: " + minStack.GetMin()); // Output: 2147483646
minStack.Pop();
minStack.Push(2147483647);
Console.WriteLine("Top: " + minStack.Top()); // Output: 2147483647
Console.WriteLine("Min: " + minStack.GetMin()); // Output: 2147483647
minStack.Push(-2147483648);
Console.WriteLine("Top: " + minStack.Top()); // Output: -2147483648
Console.WriteLine("Min: " + minStack.GetMin()); // Output: -2147483648
minStack.Pop();
Console.WriteLine("Min after pop: " + minStack.GetMin()); // Output: 2147483647

public class MinStack
{
    private readonly List<int> _stack;
    private readonly List<int> _minStack;
    private int _min = int.MaxValue;

    public MinStack()
    {
        _stack = new List<int>();
        _minStack = new List<int>();
    }

    public void Push(int val)
    {
        _stack.Add(val);

        if (val <= _min)
        {
            _min = val;
            _minStack.Add(val);
        }
    }

    public void Pop()
    {
        if (_stack.Count == 0)
        {
            return;
        }

        int i = _stack.Count - 1;
        if (_stack[i] == _min)
        {
            _minStack.RemoveAt(_minStack.Count - 1);
            if (_minStack.Count > 0)
                _min = _minStack.Last();
            else
                _min = int.MaxValue;
        }
        _stack.RemoveAt(i);
    }

    public int? Top()
    {
        if (_stack.Count == 0)
        {
            return null;
        }

        return _stack.Last();
    }

    public int? GetMin()
    {
        return _min == int.MaxValue ? null : _min;
    }
}