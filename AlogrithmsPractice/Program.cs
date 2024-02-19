int?[] array = { 3, 9, 20, null, null, 15, 7 };

BinaryTreeFromArray binaryTree = new BinaryTreeFromArray();

TreeNode? root = binaryTree.ArrayToTree(array);

Solution solution = new Solution();

IList<IList<string>> result = solution.GroupAnagrams(new string[] { "eat", "tea", "tan", "ate", "nat", "bat" });

foreach (var anagrams in result)
{
    foreach (var anagram in anagrams)
    {
        Console.Write(anagram + " ");
    }

    Console.WriteLine();
}

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        Dictionary<string, IList<string>> wordDict = new Dictionary<string, IList<string>>();

        foreach (string str in strs)
        {
            char[] charArray = str.ToCharArray();
            
            Array.Sort(charArray);
            
            string? sortedString = new string(charArray);

            if (wordDict.TryGetValue(sortedString, out IList<string>? anagrams))
            {
                anagrams.Add(str);
            }
            else
            {
                wordDict.Add(sortedString, new List<string> { str });
            }
        }

        return wordDict.Values.ToList();
    }
}