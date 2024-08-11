Console.WriteLine(IsPalindromPermutation("CATACC")); // True

bool IsPalindromPermutation(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return false;
    }

    if (input.Length == 1)
    {
        return true;
    }

    Dictionary<char, int> charCount = new();

    foreach (char ch in input)
    {
        char chLower = char.ToLower(ch);

        if (char.IsLetter(chLower))
        {
            if (!charCount.TryAdd(chLower, 1))
            {
                charCount[chLower]++;
            }
        }
    }

    int oddCount = 0;

    foreach (var item in charCount)
    {
        if (item.Value % 2 != 0)
        {
            oddCount++;
        }
    }

    return oddCount <= 1;
}