Solution solution = new Solution();

string[] tokens = new string[]
{
    "10","6","9","3","+","-11","*","/","*","17","+","5","+"
};

Console.WriteLine(solution.EvalRPN(tokens));

public class Solution
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens)
        {
            if (token == "+")
            {
                stack.Push(stack.Pop() + stack.Pop());
            }
            else if (token == "-")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b - a);
            }
            else if (token == "*")
            {
                stack.Push(stack.Pop() * stack.Pop());
            }
            else if (token == "/")
            {
                int a = stack.Pop();
                int b = stack.Pop();
                stack.Push(b / a);
            }
            else
            {
                stack.Push(int.Parse(token));
            }
        }
        
        return stack.Pop();
    }
}