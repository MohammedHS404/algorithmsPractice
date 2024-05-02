Solution solution = new Solution();

int[] candidates = new int[]
{
    2, 3, 5
};

int target = 8;

IList<IList<int>> result = solution.CombinationSum(candidates, target);

foreach (IList<int> list in result)
{
    Console.Write("[");
    foreach (int i in list)
    {
        Console.Write(i + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

public class Solution
{
    List<IList<int>> results = new List<IList<int>>();
    public IList<IList<int>> CombinationSum(int[] candidates, int target)
    {
        List<int> current = new List<int>();
        CombinationSum(candidates, 0, target, current);
        return results;
    }


    void CombinationSum(int[] candidates, int index, int target, List<int> current)
    {
        if (target == 0)
        {
            results.Add(new List<int>(current));
            return;
        }

        if (target < 0 || index == candidates.Length)
            return;

        current.Add(candidates[index]);
        CombinationSum(candidates, index, target - candidates[index], current);
        current.RemoveAt(current.Count - 1);
        CombinationSum(candidates, index + 1, target, current);

    }
}