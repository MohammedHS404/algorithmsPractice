Console.WriteLine(OneEditAway("pale", "ple")); // True

Console.WriteLine(OneEditAway("pales", "pale")); // True

Console.WriteLine(OneEditAway("pale", "bale")); // True

Console.WriteLine(OneEditAway("pale", "bake")); // False

Console.WriteLine(OneEditAway("abc", "bc")); // True

Console.WriteLine(OneEditAway("abc", "ac")); // True

Console.WriteLine(OneEditAway("abc", "ab")); // True

Console.WriteLine(OneEditAway("abc", "a")); // False

bool OneEditAway(string s1, string s2)
{
    int diff = s1.Length - s2.Length;

    if (diff > 1 || diff < -1)
    {
        return false;
    }

    if (diff == 0)
    {
        return OneEditAway_ReplacedCharacter(s1, s2);
    }

    if (diff == 1)
    {
        return OneEditAway_InsertedCharacter(s1, s2);
    }

    if (diff == -1)
    {
        return OneEditAway_InsertedCharacter(s2, s1);
    }

    return true;
}

bool OneEditAway_InsertedCharacter(string larger, string smaller)
{
    int largerIndex = 0;
    int smallerIndex = 0;

    while (largerIndex < larger.Length && smallerIndex < smaller.Length)
    {
        if (larger[largerIndex] != smaller[smallerIndex])
        {
            if (largerIndex != smallerIndex)
            {
                return false;
            }

            largerIndex++;
        }
        else
        {
            largerIndex++;
            smallerIndex++;
        }
    }

    return true;
}

bool OneEditAway_ReplacedCharacter(string s1, string s2)
{
    int count = 0;

    for (int i = 0; i < s1.Length; i++)
    {
        if (s1[i] != s2[i])
        {
            count++;
        }
    }

    return count == 1;
}