Console.WriteLine(IsPalindromPermutation("CATAC")); // True

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

    int[] charCount = new int[26];

    foreach (char ch in input)
    {
        char chLower = char.ToLower(ch);

        if (char.IsLetter(chLower))
        {
            charCount[chLower - 'a']++;
        }
    }

    int oddCount = 0;

    foreach (var item in charCount)
    {
        if (item % 2 != 0)
        {
            oddCount++;
        }
    }

    return oddCount <= 1;
}